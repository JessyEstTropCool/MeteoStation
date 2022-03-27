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
                        if (measure.HasAlarms()) config = "Done";
                        else config = "Basic";
                        data = measure.ConvertedData + " " + Collections.TypeList[measure.type].Unit;
                    }

                    dt.Rows.Add(new object[] {
                        obj.id,
                        config,
                        Collections.TypeList[obj.type].Name,// + " (" + obj.type + ")",
                        data,
                        (int)((DateTime.Now - obj.moment).TotalSeconds) + " sec",
                        measure.GetStatus()
                    });
                }
            }

            dgv.DataSource = dt;
        }

        internal static void UpdateAlarmTable(DataGridView dgv, DataTable dt)
        {
            dt.Rows.Clear();

            foreach (SensorData.Base obj in ObjectList)
            {
                if (obj.id != 0)
                {
                    SensorData.Measure measure = (SensorData.Measure)obj;

                    if (measure.HasAlarms())
                    {
                        dt.Rows.Add(new object[] {
                            obj.id,
                            measure.CriticalMin,
                            measure.WarningMin,
                            measure.GetStatus(),
                            measure.WarningMax,
                            measure.CriticalMax
                        });
                    }
                }
            }

            dgv.DataSource = dt;
        }

        //retourne toutes les id des mesures contenues dans l'objectlist
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

        //retourne toutes les id des mesures contenues dans l'objectlist
        internal static string[] GetConfiguredMeasureIds()
        {
            List<string> ids = new List<string>();

            foreach (SensorData.Base obj in Collections.ObjectList)
            {
                if (obj.id != 0)
                {
                    SensorData.Measure measure = (SensorData.Measure)obj;

                    if ( measure.IsConfigured() )
                    {
                        ids.Add(obj.id.ToString());
                    }
                }
            }

            return ids.ToArray();
        }

        //Retourne une mesure selon son id
        internal static SensorData.Measure GetMeasure(int id)
        {
            foreach (SensorData.Base obj in Collections.ObjectList)
            {
                if (id == obj.id && id != 0) return (SensorData.Measure)obj;
            }

            return null;
        }

        //Handler de la configuration basique
        internal static void MeasureBasicConfigDone(object sender, EventArgs e)
        {
            Controls.MeasureConfigControl mcc = (Controls.MeasureConfigControl)sender;
            SetBasicConfiguration(mcc.ID, mcc.Min, mcc.Max);
        }

        //Applique une configuration basique a une mesure
        internal static void SetBasicConfiguration(int ID, int min, int max)
        {
            SensorData.Measure m = GetMeasure(ID);
            m.LowLimit = min;
            m.HighLimit = max;
            SerialPortHandler.Reception.ConvertMeasure(m);

            m.CriticalMax = 0;
            m.WarningMax = 0;
            m.WarningMin = 0;
            m.CriticalMin = 0;
        }

        //Handler de la configuration d'alarmes
        internal static void MeasureAlarmConfigDone(object sender, EventArgs e)
        {
            Controls.AlarmConfigControl acc = (Controls.AlarmConfigControl)sender;
            SetAlarmConfiguration(acc.ID, acc.CritMax, acc.WarnMax, acc.WarnMin, acc.CritMin);
        }

        //Applique une configuration d'alarmes a une mesure
        internal static void SetAlarmConfiguration(int ID, int critMax, int warnMax, int warnMin, int critMin)
        {
            SensorData.Measure m = GetMeasure(ID);
            m.CriticalMax = critMax;
            m.WarningMax = warnMax;
            m.WarningMin = warnMin;
            m.CriticalMin = critMin;
            //SerialPortHandler.Reception.SetStatus(m);
        }
    }
}
