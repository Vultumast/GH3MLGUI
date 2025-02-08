using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GH3MLGUI
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            modLogComboBox.SelectedIndex = modLogComboBox.Items.IndexOf("Info");
            windowStyleComboBox.SelectedIndex = windowStyleComboBox.Items.IndexOf("Windowed");
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void openGH3ConsoleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            allowQScriptCheckBox.Enabled = false;
            modLogComboBox.Enabled = false;


            allowQScriptCheckBox.Checked = false;

            modLogComboBox.SelectedIndex = modLogComboBox.Items.IndexOf("Info");
        }

        /// <summary>
        /// Do you want a Console window to open with GH3?
        /// </summary>
        public bool OpenGH3Console
        {
            get => openGH3ConsoleCheckBox.Checked;
            set => openGH3ConsoleCheckBox.Checked = value;
        }

        /// <summary>
        /// Do you want to allow Q Script files to print to the console?
        /// </summary>
        public bool AllowQScriptPrintf
        {
            get => allowQScriptCheckBox.Checked;
            set => allowQScriptCheckBox.Checked = value;
        }

        /// <summary>
        /// The log level that mods will use
        /// </summary>
        public LogTypes ModLogType
        {
            get => (LogTypes)modLogComboBox.SelectedIndex;
            set => modLogComboBox.SelectedIndex = (int)value;
        }

        /// <summary>
        /// The window style that will be used
        /// </summary>
        public WindowStyle WindowStyle
        {
            get => (WindowStyle)windowStyleComboBox.SelectedIndex;
            set => windowStyleComboBox.SelectedIndex = (int)value;
        }
    }
}
