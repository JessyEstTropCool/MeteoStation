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

        private static DateTime lastSent = DateTime.Now;
        private static string csrf = "";

        internal static async Task GetNewToken()
        {
            HttpResponseMessage response = await client.GetAsync("http://localhost:8000/api/post/valeur");
            string responseString = await response.Content.ReadAsStringAsync();

            getCSRF(response.StatusCode, responseString);
        }

        internal static void SendDataToServer(object sender, EventArgs e)
        {
            /*if ( DateTime.Now - lastSent > sendingInterval )
            {
                Dictionary<string, string> values = new Dictionary<string, string>
                {
                    { "valeur", ((Data.SensorData.Measure)Data.Collections.ObjectList[1]).data.ToString() },
                    { "id_capteur", "1" },
                    { "csrfmiddlewaretoken", csrf }
                };

                Task.Run(() => SendPostRequest(values));
                
                lastSent = DateTime.Now;
            }*/
        }

        private static async Task SendPostRequest(Dictionary<string, string> values)
        {
            FormUrlEncodedContent postParams = new FormUrlEncodedContent(values);
            HttpResponseMessage response = await client.PostAsync("http://localhost:8000/api/post/valeur", postParams);
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
            HttpResponseMessage response = await client.GetAsync("http://localhost:8000/api/type/");
            string responseString = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                DBTypes typesJson = js.Deserialize<DBTypes>(responseString);

                foreach ( DBTypes.DBType type in typesJson.types )
                {
                    Data.Collections.TypeDict.Add(type.id, new Data.SensorData.MeasureType(type.nom, type.unite));
                    //Task.Run(() => MessageBox.Show(type.id + " : " + type.nom + " (" + type.unite + ")"));
                }
            }
            else
            {
                Data.Collections.TypeDict.Add(1, new Data.SensorData.MeasureType("CO²", "ppm"));
                Data.Collections.TypeDict.Add(2, new Data.SensorData.MeasureType("Température", "°C"));
                Data.Collections.TypeDict.Add(3, new Data.SensorData.MeasureType("Humidité", "%"));
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
