using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GH3MLGUI.Forms
{
    public partial class InstallingUpdateForm : Form
    {
        public InstallingUpdateForm()
        {
            InitializeComponent();
        }

        private void InstallingUpdateForm_Load(object sender, EventArgs e)
        {
            if (Owner != null)
                Location = new Point(Owner.Location.X + Owner.Width / 2 - Width / 2,
                    Owner.Location.Y + Owner.Height / 2 - Height / 2);

            conduitPictureBox.BackgroundImage = Properties.Resources.conduit_tap_l;
            conduitTimer.Start();
        }
        bool _closeCalled = false;

        int _conduitFrame = 0;
        private void conduitTimer_Tick(object sender, EventArgs e)
        {
            _conduitFrame = (_conduitFrame + 1) % 2;
            conduitPictureBox.BackgroundImage = _conduitFrame == 0 ? Properties.Resources.conduit_tap_l : Properties.Resources.conduit_tap_r;

            if (UpdateManager.InstallingComplete && !_closeCalled)
            {
                _closeCalled = true;
                Close();
            }
        }

        private void InstallingUpdateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = (e.CloseReason == CloseReason.UserClosing);
        }
    }
}
