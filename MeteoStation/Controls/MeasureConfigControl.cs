using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeteoStation.Controls
{
    public partial class MeasureConfigControl : UserControl
    {
        Data.SensorData.Measure Measure { get; set; }

        public MeasureConfigControl()
        {
            InitializeComponent();
        }
    }
}
