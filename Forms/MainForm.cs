using GH3MLGUI.Properties;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GH3MLGUI.Forms;
using static GH3MLGUI.Common.Directories;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    public void AddMod(ModInfo modInfo)
    {
        var item = modsListView.Items.Add(modInfo.DisplayName);
        item.SubItems.Add(modInfo.Author);
        item.SubItems.Add(modInfo.Version);

        string tagString = string.Empty;
        item.SubItems.Add(modInfo.Tags.ToString());

    }

    public void RefreshModList()
    {
        modsListView.Items.Clear();

        var dirs = Directory.GetDirectories(ModsDirectory);

        foreach (var dir in dirs)
        {
            Console.WriteLine($"Found directory \"{dir}\"");
            var modInfoPath = Path.Combine(Path.Combine(dir, "modinfo.json"));
            if (File.Exists(modInfoPath))
            {
                ModInfo? info = null;
                if (ModInfo.TryRead(modInfoPath, out info))
                    AddMod(info!);
            }
            else
                Console.WriteLine($"Could not find: \"{modInfoPath}\" so the directory is ineligible.");
        }
    }

    private bool _isLoading = false;
    private void MainForm_Load(object sender, EventArgs e)
    {
        _isLoading = true;

        moveModToTopButton.Enabled = false;
        moveModUpButton.Enabled = false;
        moveModDownButton.Enabled = false;
        moveModToBottomButton.Enabled = false;

        removeModButton.Enabled = false;

        foreach (var value in Enum.GetNames(typeof(WindowStyle)))
            windowStyleComboBox.Items.Add(value);

        windowStyleComboBox.SelectedIndex = (int)Program.Settings.WindowStyle;

        windowResolutionXNumericUpDown.Value = Program.Settings.WindowSize.Width;
        windowResolutionYNumericUpDown.Value = Program.Settings.WindowSize.Height;

        _isLoading = false;
    }

    private void launchButton_Click(object sender, EventArgs e)
    {

    }

    #region Mod List
    private void modsListView_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (modsListView.SelectedIndices.Count == 0)
        {
            moveModToTopButton.Enabled = false;
            moveModUpButton.Enabled = false;
            moveModDownButton.Enabled = false;
            moveModToBottomButton.Enabled = false;

            removeModButton.Enabled = false;
        }

    }

    private void refreshModListButton_Click(object sender, EventArgs e) => RefreshModList();

    private void moveModToTopButton_Click(object sender, EventArgs e)
    {

    }

    private void moveModUpButton_Click(object sender, EventArgs e)
    {

    }

    private void moveModDownButton_Click(object sender, EventArgs e)
    {

    }

    private void moveModToBottomButton_Click(object sender, EventArgs e)
    {

    }

    private void addModButton_Click(object sender, EventArgs e)
    {
        using ModInfoForm form = new ModInfoForm();

        if (form.ShowDialog() == DialogResult.OK)
        {

        }
    }

    private void removeModButton_Click(object sender, EventArgs e)
    {

    }
    #endregion

    #region Game Options

    #region Window Settings
    private void windowStyleComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (_isLoading)
            return;

        Program.Settings.WindowStyle = (WindowStyle)windowStyleComboBox.SelectedIndex;
    }

    private void vsyncCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        if (_isLoading)
            return;

        Program.Settings.VSync = vsyncCheckBox.Checked;
    }

    private void windowResolutionXNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
        if (_isLoading)
            return;

        Program.Settings.WindowSize = new Size((int)windowResolutionXNumericUpDown.Value, Program.Settings.WindowSize.Height);
    }

    private void windowResolutionYNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
        if (_isLoading)
            return;

        Program.Settings.WindowSize = new Size(Program.Settings.WindowSize.Width, (int)windowResolutionYNumericUpDown.Value);
    }
    #endregion

    #endregion

}
