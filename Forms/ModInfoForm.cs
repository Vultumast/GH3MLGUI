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
        private ModInfo? _info = null;

        public ModInfoForm(ModInfo? info = null)
        {
            _info = info;
            InitializeComponent();
        }
        private ModTag[] _tagValues = [ ];
        private void ModInfoForm_Load(object sender, EventArgs e)
        {
            tagsCheckedListBox.Items.Clear();
            _tagValues = Enum.GetValues<ModTag>();
            foreach (var value in _tagValues)
            {
                if (value == ModTag.Unspecified)
                    continue;
                tagsCheckedListBox.Items.Add(value.ToString());
            }

            if (_info is null)
                _info = new ModInfo();

            displayNameTextBox.Text = _info.DisplayName;
            nameTextBox.Text = _info.Name;
            authorTextBox.Text = _info.Author;
            versionTextBox.Text = _info.Version;
            descriptionTextBox.Text = _info.Description;

            for (var i = 1; i < _tagValues.Count(); i++)
                tagsCheckedListBox.SetItemCheckState(i - 1, (_info.Tags & _tagValues[i]) != 0 ? CheckState.Checked : CheckState.Unchecked);
        }
        public string DisplayNameText
        {
            get => displayNameTextBox.Text;
            set => displayNameTextBox.Text = value;
        }
        public string NameText
        {
            get => nameTextBox.Text;
            set => nameTextBox.Text = value;
        }
        public string AuthorText
        {
            get => authorTextBox.Text;
            set => authorTextBox.Text = value;
        }
        public string VersionText
        {
            get => versionTextBox.Text;
            set => versionTextBox.Text = value;
        }
        public string Description
        {
            get => descriptionTextBox.Text;
            set => descriptionTextBox.Text = value;
        }

        private ModTag _modTags = ModTag.Unspecified;

        public ModTag ModTags
        {
            get => _modTags;
            set
            {
                _modTags = value;
                for (var i = 1; i < _tagValues.Count(); i++)
                    tagsCheckedListBox.SetItemCheckState(i - 1, (_modTags & _tagValues[i]) != 0 ? CheckState.Checked : CheckState.Unchecked);
                
            }
        }
        private void okayButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void tagsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tagsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
                _modTags |= (ModTag)(e.Index + 1);
            else if (e.NewValue == CheckState.Unchecked)
                _modTags &= ~(ModTag)(e.Index + 1);
        }
    }
}
