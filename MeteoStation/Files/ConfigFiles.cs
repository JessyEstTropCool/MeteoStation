using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeteoStation.Data;

namespace MeteoStation.Files
{
    class ConfigFiles
    {
        const string CONFIG_FILENAME = "Configs.csv",
            CONFIG_FILE_HEADER = "MeteoStation_Measure_Config_File", 
            CONFIG_FILE_CONTENT_DESC = "ID; Type; LowLimit; HighLimit; CriticalMin; WarningMin; WarningMax; CriticalMax; AlarmMaxPeriod",
            START_READ = "start", END_READ = "end";

        //Enregistre les configuration des mesures qui l'ont été ainsi que les configuration du fichier qui n'ont pas été appliquées
        internal static void SaveConfigs()
        {
            using (StreamWriter writer = new StreamWriter(CONFIG_FILENAME, false))
            {
                List<int> ids = new List<int>();

                writer.Write(CONFIG_FILE_HEADER + Environment.NewLine +
                    CONFIG_FILE_CONTENT_DESC + Environment.NewLine +
                    START_READ + Environment.NewLine);

                foreach ( SensorData.Base obj in Collections.ObjectList )
                {
                    if (obj.id != 0)
                    {
                        SensorData.Measure measure = (SensorData.Measure)obj;

                        ids.Add(measure.id);

                        if (measure.IsConfigured()) writer.Write(measure.id + ";" + measure.type + ";" + measure.LowLimit + ";" + measure.HighLimit + ";" +
                            measure.CriticalMin + ";" +measure.WarningMin + ";" + measure.WarningMax + ";" + measure.CriticalMax + ";" +
                            measure.AlarmMaxPeriod + Environment.NewLine);
                    }
                }

                writer.Write(END_READ + Environment.NewLine);
                writer.Close();
            }
        }

        //On load c tout
        internal static void LoadConfigs()
        {
            try
            {
                using (StreamReader reader = new StreamReader(CONFIG_FILENAME))
                {
                    string line = "";

                    if (reader.ReadLine() == CONFIG_FILE_HEADER && reader.ReadLine() == CONFIG_FILE_CONTENT_DESC)
                    {
                        while (reader.Peek() >= 0 && reader.ReadLine() != START_READ) ;

                        while ((line = reader.ReadLine()) != null && line != END_READ)
                        {
                            string[] csv = line.Split(';');
                            SensorData.Measure measure = new SensorData.Measure();

                            measure.id = byte.Parse(csv[0]);
                            measure.type = byte.Parse(csv[1]);

                            measure.LowLimit = int.Parse(csv[2]);
                            measure.HighLimit = int.Parse(csv[3]);
                            measure.CriticalMin = int.Parse(csv[4]);
                            measure.WarningMin = int.Parse(csv[5]);
                            measure.WarningMax = int.Parse(csv[6]);
                            measure.CriticalMax = int.Parse(csv[7]);
                            measure.AlarmMaxPeriod = uint.Parse(csv[8]);

                            SerialPortHandler.Reception.AddToList(measure);

                            /*MessageBox.Show("ID : " + csv[0] +
                                "\nType : " + csv[1] +
                                "\nLowLimit : " + csv[2] +
                                "\nHighLimit : " + csv[3] +
                                "\nCriticalMin : " + csv[4] +
                                "\nWarningMin : " + csv[5] +
                                "\nWarningMax : " + csv[6] +
                                "\nCriticalMax : " + csv[7] +
                                "\nMaxPeriod : " + csv[8]);*/
                        }
                    }

                    reader.Close();
                }
            }
            catch (Exception e)
            {
                e.Message
            }
        }
    }
}
