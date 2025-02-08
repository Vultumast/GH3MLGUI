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
    public partial class ModInfoForm : Form
    {
        public ModInfoForm()
        {
            InitializeComponent();
        }

        private void ModInfoForm_Load(object sender, EventArgs e)
        {
            tagsCheckedListBox.Items.Clear();

            foreach (var value in Enum.GetValues<ModTag>())
            {
                if (value == ModTag.Unspecified)
                    continue;
                tagsCheckedListBox.Items.Add(value.ToString());
            }

            var nfo = new ModInfo();

            displayNameTextBox.Text = nfo.DisplayName;
            nameTextBox.Text = nfo.Name;
            authorTextBox.Text = nfo.Author;
            descriptionTextBox.Text = nfo.Description;
        }

        private void okayButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
