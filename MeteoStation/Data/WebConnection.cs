﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;
using System.Net;
using System.Web.Script.Serialization;

namespace MeteoStation.Data
{
    class WebConnection
    {
        private static readonly HttpClient client = new HttpClient();
        private static readonly string localAddress = "http://localhost:8000/", remoteAddress = "http://51.178.38.149/";

        internal static TimeSpan sendingInterval = new TimeSpan(0, 0, 30); //(heures, minutes, secondes)
        internal static DateTime lastSent = DateTime.Now;
        internal static string csrf = "";

        internal static string BaseAddress { get; set; } = remoteAddress;
        internal static DateTime SentDataTime { get => lastSent; }
        internal static bool Sending { get; set; } = true;
        internal static string LastAddress { get; set; } = "";
        internal static string LastResponse { get; set; } = "No requests sent";

        internal static void SetAddress(int state)
        {
            switch ( state )
            {
                case 0:
                    BaseAddress = localAddress;
                    break;

                case 1:
                    BaseAddress = remoteAddress;
                    break;
            }
        }

        internal static async Task GetNewToken()
        {
            HttpResponseMessage response = await client.GetAsync(BaseAddress + "api/post/valeur");
            string responseString = await response.Content.ReadAsStringAsync();

            getCSRF(response.StatusCode, responseString);
        }

        internal static void SendDataToServer(object sender, EventArgs e)
        {
            if ( Sending && DateTime.Now - lastSent > sendingInterval )
            {
                Task.Run(() => Data.WebConnection.SendValuesRequest());
            }
        }

        internal static async Task SendValuesRequest()
        {
            string args = "";

            foreach (SensorData.Base obj in Collections.ObjectList)
            {
                if (obj.id != 0)
                {
                    SensorData.Measure m = (SensorData.Measure)obj;

                    if (m.IsConfigured() && m.moment > lastSent)
                    {
                        args += "&id[]=" + m.id + "&serial[]=" + m.serial + "&value[]=" + m.ConvertedData;
                    }
                }
            }

            if (args != "")
            {
                args = args.Substring(1);

                LastAddress = BaseAddress + "api/post/multivalue?" + args;

                HttpResponseMessage response = await client.GetAsync(LastAddress);
                string responseString = await response.Content.ReadAsStringAsync();

                lastSent = DateTime.Now;
                //MessageBox.Show(response.ToString());
                LastResponse = response.ToString();

                getCSRF(response.StatusCode, responseString);

                if (csrf == "") await GetNewToken();
            }
        }

        private static void getCSRF(HttpStatusCode status, string response)
        {
            if ( status == HttpStatusCode.OK )
            {
                string elementStart = "<input type=\"hidden\" name=\"csrfmiddlewaretoken\" value=\"";
                int index = response.IndexOf(elementStart) + elementStart.Length;

                string temp = response.Substring(index);

                csrf = temp.Substring(0, temp.IndexOf("\""));

                //MessageBox.Show(response);
            }
            else
            {
                csrf = "";
                //MessageBox.Show(status.ToString() + "\n" + response);
            }
        }

        internal static async Task GetTypes()
        {
            HttpResponseMessage response = await client.GetAsync(BaseAddress + "api/type/");
            string responseString = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Dictionary<int, SensorData.MeasureType> tempDict = new Dictionary<int, SensorData.MeasureType>();
                JavaScriptSerializer js = new JavaScriptSerializer();
                DBTypes typesJson = js.Deserialize<DBTypes>(responseString);

                foreach ( DBTypes.DBType type in typesJson.types )
                {
                    Data.Collections.TypeDict.Add(type.id, new Data.SensorData.MeasureType(type.nom, type.unite));
                    //Task.Run(() => MessageBox.Show(type.id + " : " + type.nom + " (" + type.unite + ")"));
                }

                Data.Collections.TypeDict = tempDict;
            }
        }
    }

    internal class DBTypes
    {
        public List<DBType> types { get; set; }

        internal class DBType
        {
            public int id { get; set; }
            public string nom { get; set; }
            public string unite { get; set; }
            public int criticalMax { get; set; }
            public int criticalMin { get; set; }
            public int warningMax { get; set; }
            public int warningMin { get; set; }
            public int maxPeriod { get; set; }
        }
    }
}
