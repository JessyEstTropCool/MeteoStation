using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeteoStation.Data;

namespace MeteoStation.Files
{
    class ConfigFiles
    {
        const string CONFIG_FILENAME = "Configs.csv";

        //Enregistre les configuration des mesures qui l'ont été ainsi que les configuration du fichier qui n'ont pas été appliquées
        internal static void SaveConfigs()
        {
            using (StreamWriter writer = new StreamWriter(CONFIG_FILENAME, false))
            {
                List<int> ids = new List<int>();

                writer.Write("MeteoStation_Measure_Config_File" + Environment.NewLine +
                    "ID; LowLimit; HighLimit; CriticalMin; WarningMin; WarningMax; CriticalMax; AlarmMaxPeriod" + Environment.NewLine +
                    "start" + Environment.NewLine);

                foreach ( SensorData.Base obj in Collections.ObjectList )
                {
                    if (obj.id != 0)
                    {
                        SensorData.Measure measure = (SensorData.Measure)obj;

                        ids.Add(measure.id);

                        if (measure.IsConfigured()) writer.Write(measure.id + ";" + measure.LowLimit + ";" + measure.HighLimit + ";" +
                            measure.CriticalMin + ";" +measure.WarningMin + ";" + measure.WarningMax + ";" + measure.CriticalMax + ";" +
                            measure.AlarmMaxPeriod + Environment.NewLine);
                    }
                }

                foreach (int key in Collections.LoadedConfigs.Keys)
                {
                    if (ids.Contains(key))
                    {
                        SensorData.MeasureConfig config = Collections.LoadedConfigs[key];

                        writer.Write(key + ";" + config.LowLimit + ";" + config.HighLimit + ";" +
                            config.CriticalMin + ";" + config.WarningMin + ";" + config.WarningMax + ";" + config.CriticalMax + ";" +
                            config.AlarmMaxPeriod + Environment.NewLine);
                    }
                }

                writer.Write("end" + Environment.NewLine);
                writer.Close();
            }
        }

        //On load c tout
        internal static void LoadConfigs()
        {

        }
    }
}
