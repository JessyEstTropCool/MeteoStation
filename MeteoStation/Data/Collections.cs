﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace MeteoStation.Data
{
    internal class Collections
    {
        internal static Queue<byte> SerialBuffer { get; set; } = new Queue<byte>();
        internal static ArrayList ObjectList { get; set; } = new ArrayList();
        internal static Dictionary<int, SensorData.MeasureType> TypeDict { get; set; } = new Dictionary<int, SensorData.MeasureType>();

        internal static SensorData.MeasureType GetType(int index)
        {
            if (TypeDict.ContainsKey(index))
                return TypeDict[index];
            else
                return new SensorData.MeasureType("Type " + index, "?");
        }

        //met les infos des measures de la liste sur la table
        internal static void UpdateMeasureTable(DataGridView dgv)
        {
            DataTable dt = Tables.MeasureTable;
            dt.Rows.Clear();

            foreach (SensorData.Base obj in ObjectList)
            {
                string config = "None", data = obj.data.ToString(), lastUpdate = "";

                if (obj.id != 0)
                {
                    SensorData.Measure measure = (SensorData.Measure)obj;

                    if ( measure.IsConfigured() )
                    {
                        if (measure.HasAlarms()) config = "Done";
                        else config = "Basic";
                        data = measure.ConvertedData + " " + GetType(measure.type).Unit;
                    }

                    if (measure.moment != DateTime.MinValue) lastUpdate = (int)((DateTime.Now - obj.moment).TotalSeconds) + " sec";
                    else lastUpdate = "-";

                    dt.Rows.Add(new object[] {
                        obj.id,
                        config,
                        GetType(obj.type).Name,// + " (" + obj.type + ")",
                        data,
                        lastUpdate,
                        measure.GetStatus()
                    });

                    SetStatusColor(dgv, measure, 5, dt.Rows.Count - 1);
                }
            }

            dgv.DataSource = dt;
        }

        //met les infos des mesures avec alarmes de la liste sur la table
        internal static void UpdateAlarmTable(DataGridView dgv)
        {
            DataTable dt = Tables.AlarmTable;
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

                        SetStatusColor(dgv, measure, 3, dt.Rows.Count - 1);
                    }
                }
            }

            dgv.DataSource = dt;
        }

        //met les infos des mesures qu'on peut envoyer de la liste sur la table
        internal static void UpdateSendableTable(DataGridView dgv)
        {
            DataTable dt = Tables.SendableTable;
            dt.Rows.Clear();

            foreach (SensorData.Base obj in ObjectList)
            {
                if (obj.id != 0)
                {
                    SensorData.Measure measure = (SensorData.Measure)obj;

                    if (measure.IsConfigured())
                    {
                        dt.Rows.Add(new object[] {
                            obj.serial,
                            obj.id,
                            GetType(obj.type).Name
                        });
                    }
                }
            }

            dgv.DataSource = dt;
        }

        //Colore un cellule d'un dgv avec la couleur qui correspond au status d'une mesure
        internal static void SetStatusColor(DataGridView dgv, SensorData.Measure measure, int x, int y)
        {
            Color c;

            switch (measure.GetStatus())
            {
                case "Normal":
                    c = Color.PaleGreen;
                    break;

                case "Warning":
                    c = Color.FromArgb(254, 230, 133);
                    break;

                case "Critical":
                    c = Color.LightCoral;
                    break;

                case "Obselete":
                    c = Color.BlueViolet;
                    break;

                default:
                    c = dgv.DefaultCellStyle.BackColor;
                    break;
            }

            if (dgv.Rows.Count > 0)
                dgv.Rows[y].Cells[x].Style.BackColor = c;
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

        //EventHandler pour l'ouverture de combo box du measure config control
        internal static void MeasureConfigDropDown(object sender, EventArgs e)
        {
            ((Controls.MeasureConfigControl)sender).SetCbItems(GetMeasureIds());
        }

        //EventHandler pour la fermeture du combo box du measure config control
        internal static void MeasureConfigDropDownClosed(object sender, EventArgs e)
        {
            Controls.MeasureConfigControl mcc = (Controls.MeasureConfigControl)sender;
            SensorData.Measure measure = null;

            if (mcc.SelectedItem != null)
            {
                mcc.ID = int.Parse((string)mcc.SelectedItem);
                measure = GetMeasure(mcc.ID);

                mcc.UpdateInfo(measure.LowLimit, measure.HighLimit, GetType(measure.type).Name, GetType(measure.type).Unit, measure.IsConfigured());
            }
        }

        //retourne une liste des id de toutes les mesures
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

        //Handler de la configuration basique qui vérifie que les données ont du sens avant de modifier la mesure
        internal static void MeasureBasicConfigDone(object sender, EventArgs e)
        {
            Controls.MeasureConfigControl mcc = (Controls.MeasureConfigControl)sender;
            SensorData.Measure measure = null;

            if (mcc.ID == -1) mcc.SendError(0);
            else if (mcc.Min >= mcc.Max) mcc.SendError(1);
            else
            {
                measure = GetMeasure(mcc.ID);

                SetBasicConfiguration(mcc.ID, mcc.Min, mcc.Max);
                mcc.UpdateInfo(measure.LowLimit, measure.HighLimit, GetType(measure.type).Name, GetType(measure.type).Unit, measure.IsConfigured());
            }
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

        //EventHandler pour l'ouverture de combo box du alarm config control
        internal static void AlarmConfigDropDown(object sender, EventArgs e)
        {
            ((Controls.AlarmConfigControl)sender).SetCbItems(GetConfiguredMeasureIds());
        }

        //EventHandler pour la fermeture de combo box du alarm config control
        internal static void AlarmConfigDropDownClosed(object sender, EventArgs e)
        {
            Controls.AlarmConfigControl acc = (Controls.AlarmConfigControl)sender;
            SensorData.Measure measure;

            if (acc.SelectedItem != null)
            {
                acc.ID = int.Parse((string)acc.SelectedItem);
                measure = GetMeasure(acc.ID);

                if (measure.HasAlarms()) acc.UpdateInfo(measure.LowLimit, measure.HighLimit, measure.CriticalMax, measure.WarningMax, measure.WarningMin, measure.CriticalMin, (int)measure.AlarmMaxPeriod, GetType(measure.type).Name, measure.HasAlarms());
                else acc.UpdateInfo(measure.LowLimit, measure.HighLimit, (int)measure.AlarmMaxPeriod, GetType(measure.type).Name);
            }
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

                    if (measure.IsConfigured())
                    {
                        ids.Add(obj.id.ToString());
                    }
                }
            }

            return ids.ToArray();
        }

        //Handler de la configuration d'alarmes qui vérifie les données du control avant de les mettre
        internal static void MeasureAlarmConfigDone(object sender, EventArgs e)
        {
            Controls.AlarmConfigControl acc = (Controls.AlarmConfigControl)sender;
            SensorData.Measure m;

            if (acc.ID == -1) acc.SendError(0);
            else
            {
                m = Collections.GetMeasure(acc.ID);

                if (acc.CritMax > m.HighLimit || acc.WarnMax > m.HighLimit || acc.WarnMin < m.LowLimit || acc.CritMin < m.LowLimit) acc.SendError(1);
                else if (acc.CritMin > acc.CritMax || acc.WarnMin > acc.WarnMax) acc.SendError(2);
                else if (acc.WarnMax > acc.CritMax || acc.WarnMin < acc.CritMin) acc.SendError(3);
                else if (acc.MaxPeriod <= 0) acc.SendError(4);
                else 
                    SetAlarmConfiguration(acc.ID, acc.CritMax, acc.WarnMax, acc.WarnMin, acc.CritMin, acc.MaxPeriod);
            }

        }

        //Applique une configuration d'alarmes a une mesure
        internal static void SetAlarmConfiguration(int ID, int critMax, int warnMax, int warnMin, int critMin, uint maxPeriod)
        {
            SensorData.Measure m = GetMeasure(ID);
            m.CriticalMax = critMax;
            m.WarningMax = warnMax;
            m.WarningMin = warnMin;
            m.CriticalMin = critMin;
            m.AlarmMaxPeriod = maxPeriod;
        }

        internal static String GetMeasureInfo(int id)
        {
            SensorData.Measure m = GetMeasure(id);

            return m.serial + " - " + m.id + 
                "\nType " + m.type + " (" + GetType(m.type).Name + 
                ")\n\nConfigured ? " + m.IsConfigured() +
                "\nLimits : " + m.LowLimit + " - " + m.HighLimit +
                "\n\nAlarms ? " + m.HasAlarms() + 
                "\n" + m.CriticalMin + " - " + m.WarningMin + " - OK - " + m.WarningMax + " - " + m.CriticalMax +
                "\n\nMax Period : " + m.AlarmMaxPeriod + " (seconds)";
        }
    }
}
