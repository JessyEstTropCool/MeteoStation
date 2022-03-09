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

        internal static void DataTreatment(MainForm form, DataGridView dgv, DataTable dt)
        {
            while (Data.Collections.SerialBuffer.Count > 14 )
            {
                Data.SensorData.Base obj = new Data.SensorData.Measure();

                FilterQueue();

                Data.Collections.SerialBuffer.Dequeue();
                Data.Collections.SerialBuffer.Dequeue();
                Data.Collections.SerialBuffer.Dequeue();

                obj.id = Data.Collections.SerialBuffer.Dequeue();
                obj.type = Data.Collections.SerialBuffer.Dequeue();
                obj.nbrBytes = Data.Collections.SerialBuffer.Dequeue();

                //if (obj.nbrBytes > 4) MessageBox.Show("???");

                for ( int compt = 0; compt < obj.nbrBytes; compt++ )
                {
                    obj.data = (obj.data << 8) + Data.Collections.SerialBuffer.Dequeue();
                }

                byte checksum = Data.Collections.SerialBuffer.Dequeue();

                Data.Collections.SerialBuffer.Dequeue();
                Data.Collections.SerialBuffer.Dequeue();
                Data.Collections.SerialBuffer.Dequeue();

                byte sum = 0;

                foreach (byte b in BitConverter.GetBytes(obj.data))
                    sum += b;

                if (checksum == (byte)(obj.id + obj.type + obj.nbrBytes + sum) /*&& obj.id != 0*/) AddToList(obj, dt, dgv);
                else /*if (obj.id != 0)*/ errors++;
            }
        }

        internal static void AddToList(Data.SensorData.Base obj, DataTable dt, DataGridView dg)
        {
            bool isIn = false;

            foreach ( Data.SensorData.Base m in Data.Collections.ObjectList )
            {
                if (m.id == obj.id)
                {
                    isIn = true;
                    m.data = obj.data;
                    m.type = obj.type;
                    m.nbrBytes = obj.nbrBytes;
                    m.moment = obj.moment;

                    foreach (DataRow dr in dt.Rows) 
                    {
                        if (dr["ID"].ToString() == obj.id.ToString())
                        {
                            dr["TYPE"] = ((Data.SensorData.MeasureType)Data.Collections.TypeList[obj.type]).Name + " (" + obj.type + ")";
                            dr["DATA"] = obj.data;
                            dr["UPDATE"] = obj.moment.ToLongTimeString();
                        }
                    }
                }
            }
            
            if (!isIn)
            {
                if (Data.Collections.ObjectList.Count == 0) 
                {
                    Data.Collections.ObjectList.Add(obj);
                    dt.Rows.Add(new object[] { obj.id, "None", ((Data.SensorData.MeasureType)Data.Collections.TypeList[obj.type]).Name + " (" + obj.type + ")", obj.data, obj.moment.ToLongTimeString(), "None" });
                }
                else
                {
                    int i = 0;

                    foreach (Data.SensorData.Base m in Data.Collections.ObjectList)
                    {
                        if (m.id > obj.id)
                        {
                            DataRow row = dt.NewRow();
                            row["ID"] = obj.id;
                            row["CONFIG"] = "None";
                            row["TYPE"] = ((Data.SensorData.MeasureType)Data.Collections.TypeList[obj.type]).Name + " (" + obj.type + ")";
                            row["DATA"] = obj.data;
                            row["UPDATE"] = obj.moment.ToLongTimeString();
                            row["ALARM"] = "None";

                            Data.Collections.ObjectList.Insert(i, obj);
                            dt.Rows.InsertAt(row, i);
                            break;
                        }
                        else i++;
                    }
                }
            }

            dg.DataSource = dt;
        }

        internal static void FilterQueue()
        {
            while (Data.Collections.SerialBuffer.Count > 3
                && Data.Collections.SerialBuffer.ElementAt(0) != Convert.ToByte("55", 16)
                && Data.Collections.SerialBuffer.ElementAt(1) != Convert.ToByte("55", 16)
                && Data.Collections.SerialBuffer.ElementAt(2) != Convert.ToByte("AA", 16))
            {
                Data.Collections.SerialBuffer.Dequeue();
            }

            //MessageBox.Show(Data.Collections.SerialBuffer.ElementAt(0) + " " + Data.Collections.SerialBuffer.ElementAt(1) + " " + Data.Collections.SerialBuffer.ElementAt(2));
        }
    }
}
