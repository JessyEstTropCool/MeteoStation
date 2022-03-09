using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace MeteoStation.SerialPortHandler
{
    internal static partial class Reception
    {
        internal static void RecieveData(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            int length = sp.BytesToRead;
            byte[] newbytes = new byte[length];

            sp.Read(newbytes, 0, length);

            for (int compt = 0; compt < newbytes.Length; compt++) Data.Collections.SerialBuffer.Enqueue(newbytes[compt]);
        }
    }
}
