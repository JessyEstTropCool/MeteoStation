using System;
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
        private static readonly TimeSpan sendingInterval = new TimeSpan(0, 0, 30);
        private static readonly string baseAddress = "http://localhost:8000/";

        private static DateTime lastSent = DateTime.Now;
        private static string csrf = "";

        internal static async Task GetNewToken()
        {
            HttpResponseMessage response = await client.GetAsync(baseAddress + "api/post/valeur");
            string responseString = await response.Content.ReadAsStringAsync();

            getCSRF(response.StatusCode, responseString);
        }

        internal static void SendDataToServer(object sender, EventArgs e)
        {
            if ( DateTime.Now - lastSent > sendingInterval )
            {
                string args = "";

                foreach (SensorData.Base obj in Collections.ObjectList)
                {
                    if (obj.id != 0)
                    {
                        SensorData.Measure m = (SensorData.Measure)obj;

                        if ( m.IsConfigured() && m.moment > lastSent )
                        {
                            args += "&id[]=" + m.id + "&serial[]=" + m.serial + "&value[]=" + m.ConvertedData;
                        }
                    }
                }

                if ( args != "" )
                    Task.Run(() => SendValuesRequest(args.Substring(1)));
                
                lastSent = DateTime.Now;
            }
        }

        private static async Task SendValuesRequest(string args)
        {
            HttpResponseMessage response = await client.GetAsync(baseAddress + "api/post/multivalue?" + args);
            string responseString = await response.Content.ReadAsStringAsync();

            getCSRF(response.StatusCode, responseString);

            if (csrf == "") await GetNewToken();
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
            HttpResponseMessage response = await client.GetAsync(baseAddress + "api/type/");
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
