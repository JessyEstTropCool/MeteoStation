using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Data;

namespace MeteoStation.Data
{
    internal class Collections
    {
        internal static Queue<byte> SerialBuffer { get; set; } = new Queue<byte>();
        internal static ArrayList ObjectList { get; set; } = new ArrayList();
        internal static List<SensorData.MeasureType> TypeList { get; set; } = new List<SensorData.MeasureType>();

        //met les infos de la liste sur la table
        internal static void UpdateMeasureTable(DataGridView dgv, DataTable dt)
        {
            dt.Rows.Clear();

            foreach (SensorData.Base obj in ObjectList)
            {
                string config = "None", data = obj.data.ToString();

                if (obj.id != 0)
                {
                    SensorData.Measure measure = (SensorData.Measure)obj;

                    if ( measure.IsConfigured() )
                    {
                        config = "Done";
                        data = measure.ConvertedData + " " + Collections.TypeList[measure.type].Unit;
                    }

                    dt.Rows.Add(new object[] {
                        obj.id,
                        config,
                        Collections.TypeList[obj.type].Name,// + " (" + obj.type + ")",
                        data,
                        (int)((DateTime.Now - obj.moment).TotalSeconds) + " sec",
                        "None"
                    });
                }
            }

            dgv.DataSource = dt;
        }

        internal static string[] GetMeasureIds()
        {
            List<string> ids = new List<string>();

            foreach (SensorData.Base obj in Collections.ObjectList)
            {
                if (obj.id != 0)
                {
                    ids.Add(obj.id.ToString());
                }
            }

            return ids.ToArray();
        }

        internal static SensorData.Measure GetMeasure(int id)
        {
            foreach (SensorData.Base obj in Collections.ObjectList)
            {
                if (id == obj.id && id != 0) return (SensorData.Measure)obj;
            }

            return null;
        }

        internal static void MeasureConfigDone(object sender, EventArgs e)
        {
            Controls.MeasureConfigControl mcc = (Controls.MeasureConfigControl)sender;
            SetBasicConfiguration(mcc.ID, mcc.Min, mcc.Max);
        }

        internal static void SetBasicConfiguration(int ID, int min, int max)
        {
            SensorData.Measure m = GetMeasure(ID);
            m.LowLimit = min;
            m.HighLimit = max;
        }
    }
}
