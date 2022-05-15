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
    public partial class ConnectionControl : UserControl
    {
        public ConnectionControl()
        {
            InitializeComponent();

            FetchInfo(null, EventArgs.Empty);
        }

        internal void FetchInfo(object sender, EventArgs e)
        {
            string info = "Sending data : " + Data.WebConnection.Sending;
            info += "\nAddress : " + Data.WebConnection.BaseAddress;
            info += "\nLatest Send : " + Data.WebConnection.SentDataTime;

            lInfo.Text = info;
        }
    }
}
