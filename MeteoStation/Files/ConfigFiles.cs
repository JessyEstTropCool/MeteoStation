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
            CONFIG_FILE_CONTENT_DESC = "Serial; ID; Type; LowLimit; HighLimit; CriticalMin; WarningMin; WarningMax; CriticalMax; AlarmMaxPeriod",
            START_READ = "start", END_READ = "end";

        //Enregistre les configuration des mesures qui l'ont été ainsi que les configuration du fichier qui n'ont pas été appliquées
        internal static void SaveConfigs()
        {
            ExportConfigs(CONFIG_FILENAME);
        }

        internal static void ExportConfigs(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename, false))
            {
                List<int> ids = new List<int>();

                writer.Write(CONFIG_FILE_HEADER + Environment.NewLine +
                    CONFIG_FILE_CONTENT_DESC + Environment.NewLine +
                    START_READ + Environment.NewLine);

                foreach (SensorData.Base obj in Collections.ObjectList)
                {
                    if (obj.id != 0)
                    {
                        SensorData.Measure measure = (SensorData.Measure)obj;

                        ids.Add(measure.id);

                        if (measure.IsConfigured()) writer.Write(measure.serial + ";" + measure.id + ";" + measure.type + ";" + measure.LowLimit + ";" + measure.HighLimit + ";" +
                            measure.CriticalMin + ";" + measure.WarningMin + ";" + measure.WarningMax + ";" + measure.CriticalMax + ";" +
                            measure.AlarmMaxPeriod + Environment.NewLine);
                    }
                }

                writer.Write(END_READ + Environment.NewLine);
                writer.Close();
            }
        }

        internal static bool ClearConfigs()
        {
            if (MessageBox.Show("Vous allez perdre toutes les données jusqu'ici, voulez-vous continuer ?", "Meteo Station", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if ( File.Exists(CONFIG_FILENAME) )
                {
                    try
                    {
                        File.Delete(CONFIG_FILENAME);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Erreur de fichier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                Data.Collections.ObjectList.Clear();
                return true;
            }

            return false;
        }

        internal static void ImportConfigs(string filename)
        {
            if (File.Exists(filename))
            {
                if ( (!File.Exists(CONFIG_FILENAME) || DialogResult.Yes == MessageBox.Show("Un fichier de configuration existe déjà, voulez-vous l'écraser ?", "Meteo Station", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) && ClearConfigs() )
                {
                    File.Copy(filename, CONFIG_FILENAME, true);

                    ApplyConfigs(filename);
                }
            }
            else MessageBox.Show("Ce fichier n'existe pas", "Erreur de fichier", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void LoadConfigs()
        {
            if (File.Exists(CONFIG_FILENAME))
            {
                ApplyConfigs(CONFIG_FILENAME);
            }
        }

        //On load c tout
        internal static void ApplyConfigs(string filename)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    string line = "";

                    if (!reader.EndOfStream && reader.ReadLine() == CONFIG_FILE_HEADER && !reader.EndOfStream && reader.ReadLine() == CONFIG_FILE_CONTENT_DESC)
                    {
                        while (reader.Peek() >= 0 && reader.ReadLine() != START_READ) ;

                        while ((line = reader.ReadLine()) != null && line != END_READ)
                        {
                            string[] csv = line.Split(';');
                            SensorData.Measure measure = new SensorData.Measure();

                            measure.serial = ushort.Parse(csv[0]);
                            measure.id = byte.Parse(csv[1]);
                            measure.type = byte.Parse(csv[2]);
                            measure.moment = DateTime.MinValue;

                            measure.LowLimit = int.Parse(csv[3]);
                            measure.HighLimit = int.Parse(csv[4]);
                            measure.CriticalMin = int.Parse(csv[5]);
                            measure.WarningMin = int.Parse(csv[6]);
                            measure.WarningMax = int.Parse(csv[7]);
                            measure.CriticalMax = int.Parse(csv[8]);
                            measure.AlarmMaxPeriod = uint.Parse(csv[9]);

                            SerialPortHandler.Reception.ReplaceOrAddToList(measure);
                        }
                    }
                    else MessageBox.Show("Le fichier est corrompu", "Erreur de fichier", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    reader.Close();
                }
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.Message, "Erreur de fichier", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException e)
            {
                MessageBox.Show("Could not be loaded : " + e.Message, "Erreur de fichier", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erreur de fichier", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
