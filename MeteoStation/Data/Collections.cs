using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MeteoStation.Data
{
    internal class Collections
    {
        internal static Queue<byte> SerialBuffer { get; set; } = new Queue<byte>();
        internal static ArrayList ObjectList { get; set; } = new ArrayList();
        internal static ArrayList TypeList { get; set; } = new ArrayList();
    }
}
