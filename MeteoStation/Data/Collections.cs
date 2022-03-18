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
        internal static List<Data.SensorData.MeasureType> TypeList { get; set; } = new List<Data.SensorData.MeasureType>();

        //met les infos de la liste sur la table
        internal static void UpdateMeasureTable(DataGridView dgv, DataTable dt)
        {
            dt.Rows.Clear();

            foreach (Data.SensorData.Base obj in Data.Collections.ObjectList)
            {
                dt.Rows.Add(new object[] {
                    obj.id,
                    "None",
                    ((Data.SensorData.MeasureType)Data.Collections.TypeList[obj.type]).Name + " (" + obj.type + ")",
                    obj.data,
                    (int)((DateTime.Now - obj.moment).TotalSeconds) + " sec",
                    "None"
                });
            }

            dgv.DataSource = dt;
        }

        internal static string[] GetMeasureIds()
        {
            List<string> ids = new List<string>();

            foreach (Data.SensorData.Base obj in Data.Collections.ObjectList)
            {
                if (obj.id != 0)
                {
                    ids.Add(obj.id.ToString());
                }
            }

            return ids.ToArray();
        }

        internal static Data.SensorData.Measure GetMeasure(int id)
        {
            foreach (Data.SensorData.Base obj in Data.Collections.ObjectList)
            {
                if (id == obj.id && id != 0) return (Data.SensorData.Measure)obj;
            }

            return null;
        }
    }
}
