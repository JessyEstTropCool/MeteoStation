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
        internal event DataGridViewCellEventHandler RowClick;

        public ConnectionControl()
        {
            InitializeComponent();

            FetchInfo(null, EventArgs.Empty);
        }

        internal void FetchInfo(object sender, EventArgs e)
        {
            Data.Collections.UpdateSendableTable(gGoodMeasures);
            gGoodMeasures.ClearSelection();

            lInfo.Text = "Sending data : " + Data.WebConnection.Sending +
            "\nTime interval : " + Data.WebConnection.sendingInterval +
            "\nAddress : " + Data.WebConnection.BaseAddress +
            "\nLatest Send : " + Data.WebConnection.SentDataTime;

            tbLastAddress.Text = "Address : " + Data.WebConnection.LastAddress;
            tbLastResponse.Text = Data.WebConnection.LastResponse;
        }

        private void gGoodMeasures_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowClick.Invoke(sender, e);
        }
    }
}
