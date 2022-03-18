using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Collections;

namespace MeteoStation.SerialPortHandler
{
    internal static partial class Reception
    {
        internal static int errors = 0;

        //Traite les données située dans le buffer (TODO alarmes a filtrer)
        internal static void DataTreatment()
        {
            FilterQueue();

            while (Data.Collections.SerialBuffer.Count > 13 )
            {
                Data.SensorData.Base obj = new Data.SensorData.Measure();
                byte sum = 0;

                //bytes d'entrés
                Data.Collections.SerialBuffer.Dequeue();
                Data.Collections.SerialBuffer.Dequeue();
                Data.Collections.SerialBuffer.Dequeue();

                //on décale le premier byte qu'on obtients pour avoir le nombre entier
                obj.serial = (ushort)((Data.Collections.SerialBuffer.Dequeue() << 8) + Data.Collections.SerialBuffer.Dequeue());

                obj.id = Data.Collections.SerialBuffer.Dequeue();
                obj.type = Data.Collections.SerialBuffer.Dequeue();

                obj.data = (ushort)((Data.Collections.SerialBuffer.Dequeue() << 8) + Data.Collections.SerialBuffer.Dequeue());

                byte checksum = Data.Collections.SerialBuffer.Dequeue();

                //bytes de fin
                Data.Collections.SerialBuffer.Dequeue();
                Data.Collections.SerialBuffer.Dequeue();
                Data.Collections.SerialBuffer.Dequeue();

                //comme on a directement converti le serial et data en 16 bits faut prendre les bytes 1 par 1
                foreach (byte b in BitConverter.GetBytes(obj.serial))
                    sum += b;

                foreach (byte b in BitConverter.GetBytes(obj.data))
                    sum += b;

                //vérification
                if (checksum == (byte)(obj.id + obj.type + sum) ) AddToList(obj);
                else errors++;

                //AddToList(obj); //si jamais on doit vérifier sans checksum
            }
        }

        //Ajoute une base dans la liste
        internal static void AddToList(Data.SensorData.Base obj)
        {
            bool isIn = false;

            //si il est déjà dedans on fait qu'update les données
            foreach ( Data.SensorData.Base m in Data.Collections.ObjectList )
            {
                if (m.id == obj.id)
                {
                    isIn = true;
                    m.data = obj.data;
                    m.type = obj.type;
                    m.moment = obj.moment;
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

                    foreach (Data.SensorData.Base m in Data.Collections.ObjectList)
                    {
                        if (m.id > obj.id)
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
