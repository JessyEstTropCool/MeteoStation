using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;

namespace MeteoStation.SerialPortHandler
{
    internal static partial class Reception
    {
        internal static int errors = 0;

        //Traite les données située dans le buffer
        internal static void DataTreatment()
        {
            FilterQueue();

            while (Data.Collections.SerialBuffer.Count > 13 )
            {
                Data.SensorData.Base obj;
                ushort serial, data;
                byte sum = 0, id, type;

                //bytes d'entrés
                Data.Collections.SerialBuffer.Dequeue();
                Data.Collections.SerialBuffer.Dequeue();
                Data.Collections.SerialBuffer.Dequeue();

                //on décale le premier byte qu'on obtients pour avoir le nombre entier
                serial = (ushort)((Data.Collections.SerialBuffer.Dequeue() << 8) + Data.Collections.SerialBuffer.Dequeue());

                id = Data.Collections.SerialBuffer.Dequeue();
                type = Data.Collections.SerialBuffer.Dequeue();

                data = (ushort)((Data.Collections.SerialBuffer.Dequeue() << 8) + Data.Collections.SerialBuffer.Dequeue());

                byte checksum = Data.Collections.SerialBuffer.Dequeue();

                //bytes de fin
                Data.Collections.SerialBuffer.Dequeue();
                Data.Collections.SerialBuffer.Dequeue();
                Data.Collections.SerialBuffer.Dequeue();

                //comme on a directement converti le serial et data en 16 bits faut prendre les bytes 1 par 1
                foreach (byte b in BitConverter.GetBytes(serial))
                    sum += b;

                foreach (byte b in BitConverter.GetBytes(data))
                    sum += b;

                //vérification
                if (checksum == (byte)(id + type + sum) )
                {
                    //c'est ici qu'on détermine si c'est une alarme ou un mesure
                    if (id == 0) obj = new Data.SensorData.Alarm();
                    else obj = new Data.SensorData.Measure();

                    obj.serial = serial;
                    obj.id = id;
                    obj.type = type;
                    obj.data = data;

                    AddToList(obj);
                }
                else errors++;

                //AddToList(obj); //si jamais on doit vérifier sans checksum
            }
        }

        //Ajoute une base dans la liste en remplacant tous les champs, utilisé pour les changements de config
        internal static void ReplaceOrAddToList(Data.SensorData.Base obj)
        {
            bool isIn = false;

            foreach (Data.SensorData.Base b in Data.Collections.ObjectList)
            {
                if (b.id == obj.id)
                {
                    isIn = true;
                    b.data = obj.data;
                    b.type = obj.type;
                    b.moment = obj.moment;

                    if (b.id != 0 && obj.id != 0)
                    {
                        Data.SensorData.Measure m = (Data.SensorData.Measure)b;
                        Data.SensorData.Measure neoM = (Data.SensorData.Measure)obj;

                        m.LowLimit = neoM.LowLimit;
                        m.HighLimit = neoM.HighLimit;
                        m.CriticalMin = neoM.CriticalMin;
                        m.WarningMin = neoM.WarningMin;
                        m.WarningMax = neoM.WarningMax;
                        m.CriticalMax = neoM.CriticalMax;
                        m.AlarmMaxPeriod = neoM.AlarmMaxPeriod;

                        if (m.IsConfigured())
                        {
                            ConvertMeasure(m);
                        }
                    }
                }
            }

            if (!isIn) AddToList(obj);
        }

        //Ajoute une base dans la liste
        internal static void AddToList(Data.SensorData.Base obj)
        {
            bool isIn = false;

            //si il est déjà dedans on fait qu'update les données
            foreach ( Data.SensorData.Base b in Data.Collections.ObjectList )
            {
                if (b.id == obj.id)
                {
                    isIn = true;
                    b.data = obj.data;
                    b.type = obj.type;
                    b.moment = obj.moment;

                    if (b.id != 0)
                    {
                        Data.SensorData.Measure m = (Data.SensorData.Measure)b;
                        if ( m.IsConfigured() )
                        {
                            ConvertMeasure(m);
                        }
                    }
                }
            }
            
            //sinon on doit l'ajouter
            if (!isIn)
            {
                //si ya rien on le met juste
                if (Data.Collections.ObjectList.Count == 0) 
                {
                    Data.Collections.ObjectList.Add(obj);
                }
                else
                {
                    //sinon on le met au bon endroit
                    int i = 0;

                    foreach (Data.SensorData.Base b in Data.Collections.ObjectList)
                    {
                        if (b.id > obj.id)
                        {
                            Data.Collections.ObjectList.Insert(i, obj);
                            break;
                        }
                        else i++;

                        //si on doit le mettre a la fin c'est ici
                        if (i == Data.Collections.ObjectList.Count)
                        {
                            Data.Collections.ObjectList.Add(obj);
                            break;
                        }
                    }
                }
            }
        }

        //Calcule et assigne la valeur convertie d'une mesure
        internal static void ConvertMeasure(Data.SensorData.Measure m)
        {
            m.ConvertedData = (int)((m.data * 1.0 / ushort.MaxValue) * (m.HighLimit - m.LowLimit) + m.LowLimit);
        }

        //enleve les bytes inutiles jusqu'à ce qu'on arrive au début d'une trame
        internal static void FilterQueue()
        {
            while (Data.Collections.SerialBuffer.Count > 3
                && Data.Collections.SerialBuffer.ElementAt(0) != 0x55
                && Data.Collections.SerialBuffer.ElementAt(1) != 0x55
                && Data.Collections.SerialBuffer.ElementAt(2) != 0xAA)
            {
                Data.Collections.SerialBuffer.Dequeue();
            }

            //MessageBox.Show(Data.Collections.SerialBuffer.ElementAt(0) + " " + Data.Collections.SerialBuffer.ElementAt(1) + " " + Data.Collections.SerialBuffer.ElementAt(2));
        }
    }
}
