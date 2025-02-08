using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GH3MLGUI
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            versionLabel.Text = $"Version: {Program.VersionString}";
        }

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (sender is not Control control)
                return;
            if (control.Tag is null)
                return;

            if (control.Tag.GetType() != typeof(string))
                return;

            ProcessStartInfo startInfo = new()
            {
                FileName = control.Tag.ToString(),
                UseShellExecute = true
            };

            Process.Start(startInfo);
        }

    }
}
