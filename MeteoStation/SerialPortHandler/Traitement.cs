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

        internal static void DataTreatment()
        {
            FilterQueue();

            while (Data.Collections.SerialBuffer.Count > 13 )
            {
                Data.SensorData.Base obj = new Data.SensorData.Measure();
                byte sum = 0;

                Data.Collections.SerialBuffer.Dequeue();
                Data.Collections.SerialBuffer.Dequeue();
                Data.Collections.SerialBuffer.Dequeue();

                obj.serial = (ushort)((Data.Collections.SerialBuffer.Dequeue() << 8) + Data.Collections.SerialBuffer.Dequeue());

                obj.id = Data.Collections.SerialBuffer.Dequeue();
                obj.type = Data.Collections.SerialBuffer.Dequeue();

                obj.data = (ushort)((Data.Collections.SerialBuffer.Dequeue() << 8) + Data.Collections.SerialBuffer.Dequeue());

                byte checksum = Data.Collections.SerialBuffer.Dequeue();

                Data.Collections.SerialBuffer.Dequeue();
                Data.Collections.SerialBuffer.Dequeue();
                Data.Collections.SerialBuffer.Dequeue();

                foreach (byte b in BitConverter.GetBytes(obj.serial))
                    sum += b;

                foreach (byte b in BitConverter.GetBytes(obj.data))
                    sum += b;

                if (checksum == (byte)(obj.id + obj.type + sum) ) AddToList(obj);
                else errors++;

                //AddToList(obj);
            }
        }

        internal static void AddToList(Data.SensorData.Base obj)
        {
            bool isIn = false;

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
            
            if (!isIn)
            {
                if (Data.Collections.ObjectList.Count == 0) 
                {
                    Data.Collections.ObjectList.Add(obj);
                }
                else
                {
                    int i = 0;

                    foreach (Data.SensorData.Base m in Data.Collections.ObjectList)
                    {
                        if (m.id > obj.id)
                        {
                            Data.Collections.ObjectList.Insert(i, obj);
                            break;
                        }
                        else i++;

                        if (i == Data.Collections.ObjectList.Count)
                        {
                            Data.Collections.ObjectList.Add(obj);
                            break;
                        }
                    }
                }
            }
        }

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
