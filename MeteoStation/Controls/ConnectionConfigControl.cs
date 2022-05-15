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
    public partial class ConnectionConfigControl : UserControl
    {
        public const int LOCAL = 0, REMOTE = 1;

        internal event EventHandler StateChanged;
        internal int State { get; set; } = LOCAL;
        public ConnectionConfigControl()
        {
            InitializeComponent();
        }

        private void bLocal_Click(object sender, EventArgs e)
        {
            State = LOCAL;
            StateChanged.Invoke(this, e);
        }

        private void bRemote_Click(object sender, EventArgs e)
        {
            State = REMOTE;
            StateChanged.Invoke(this, e);
        }

        private void bSend_Click(object sender, EventArgs e)
        {
            Task.Run(() => Data.WebConnection.SendValuesRequest());
        }

        private void bOnOff_Click(object sender, EventArgs e)
        {
            Data.WebConnection.Sending = !Data.WebConnection.Sending;

            if (Data.WebConnection.Sending) bOnOff.BackColor = Color.PaleGreen;
            else bOnOff.BackColor = Color.LightCoral;

            StateChanged.Invoke(this, e);
        }
    }
}
