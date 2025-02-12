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

    public ListViewItem? AddMod(ModInfo modInfo, int index = -1)
    {
        ListViewItem? item = null;
        if (index == -1)
            item = modsListView.Items.Add(modInfo.DisplayName);
        else
            item = modsListView.Items.Insert(index, modInfo.DisplayName);


        item.SubItems.Add(modInfo.Author);
        item.SubItems.Add(modInfo.Version);

        string tagString = string.Empty;
        item.SubItems.Add(modInfo.Tags.ToString());

        item.Tag = modInfo;

        return item;
    }

    public void RefreshModList()
    {
        modsListView.SuspendLayout();
        _isLoading = true;

        modsListView.Items.Clear();

        Dictionary<string, ModInfo> modInfos = [];

        var dirs = Directory.GetDirectories(ModsDirectory);

        foreach (var dir in dirs)
        {
            Console.WriteLine($"Found directory \"{dir}\"");
            var modInfoPath = Path.Combine(Path.Combine(dir, "modinfo.json"));
            if (File.Exists(modInfoPath))
            {
                if (ModInfo.TryRead(modInfoPath, out ModInfo? info))
                    modInfos.Add(info.Name, info);
            }
            else
                Console.WriteLine($"Could not find: \"{modInfoPath}\" so the directory is ineligible.");
        }

        foreach (var enabledMod in Program.Settings.EnabledMods)
        {
            if (modInfos.TryGetValue(enabledMod, out ModInfo? value))
            {
                AddMod(value)!.Checked = true;
                modInfos.Remove(enabledMod);
            }
            else
                Console.WriteLine($"{enabledMod} was not found in modlist!");
        }

        foreach (var kvPair in modInfos)
            AddMod(kvPair.Value);

        _isLoading = false;
        modsListView.ResumeLayout();
    }
    public void RefreshConfigEnabledMods()
    {
        List<string> enabledModes = [];

        foreach (int item in modsListView.CheckedIndices)
            enabledModes.Add((modsListView.Items[item].Tag as ModInfo)!.Name);

        Program.Settings.EnabledMods = enabledModes.ToArray();
        //RefreshModList();
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

        windowStyleComboBox.SelectedIndex = (int)Program.Settings.WindowStyle;

        windowResolutionXNumericUpDown.Value = Program.Settings.WindowWidth;
        windowResolutionYNumericUpDown.Value = Program.Settings.WindowHeight;

        _isLoading = false;

        RefreshModList();
    }

    private void launchButton_Click(object sender, EventArgs e)
    {

    }
    private void saveButton_Click(object sender, EventArgs e)
    {
        NylonConfig.Write(Program.Settings);
    }

    #region Mod List
    private void SwapModPositions(int direction)
    {
        modsListView.SuspendLayout();

        var prevSelectedIndex = modsListView.SelectedIndices[0];

        var dir = Math.Sign(direction); // V: Sanitize input


        var itemAIndex = modsListView.SelectedIndices[0] + dir;
        var itemBIndex = modsListView.SelectedIndices[0];

        var itemA = modsListView.Items[itemAIndex];
        var itemB = modsListView.Items[itemBIndex];

        var modA = itemA.Tag as ModInfo;
        var modB = itemB.Tag as ModInfo;

        var smallerIndex = Math.Min(itemAIndex, itemBIndex);
        var biggerIndex = Math.Max(itemAIndex, itemBIndex);
        modsListView.Items.RemoveAt(smallerIndex);
        modsListView.Items.RemoveAt(smallerIndex); // V: smallerIndex index because it's smaller and will now be the second item's index

        AddMod(modB!, smallerIndex);
        AddMod(modA!, dir == -1 ? biggerIndex : smallerIndex);

        modsListView.SelectedIndices.Clear();
        modsListView.SelectedIndices.Add(prevSelectedIndex + dir);
        modsListView.ResumeLayout();
    }
    private void MoveModToIndex(int index)
    {
        var modInfo = modsListView.SelectedItems[0].Tag as ModInfo;

        modsListView.Items.RemoveAt(modsListView.SelectedIndices[0]);

        AddMod(modInfo, index);

        modsListView.SelectedIndices.Add(index);
    }
    private void modsListView_SelectedIndexChanged(object sender, EventArgs e)
    {
        editButton.Enabled = modsListView.SelectedIndices.Count > 0;
        removeModButton.Enabled = modsListView.SelectedIndices.Count > 0;
        moveModToTopButton.Enabled = modsListView.SelectedIndices.Count > 0 && modsListView.SelectedIndices[0] > 0;
        moveModUpButton.Enabled = modsListView.SelectedIndices.Count > 0 && modsListView.SelectedIndices[0] > 0;

        moveModDownButton.Enabled = modsListView.SelectedIndices.Count > 0 && modsListView.SelectedIndices[0] < modsListView.Items.Count - 1;
        moveModToBottomButton.Enabled = modsListView.SelectedIndices.Count > 0 && modsListView.SelectedIndices[0] < modsListView.Items.Count - 1;

        descriptionTextBox.Text = modsListView.SelectedIndices.Count <= 0 ? string.Empty : (modsListView.Items[modsListView.SelectedIndices[0]].Tag as ModInfo)!.Description;
    }

    private void refreshModListButton_Click(object sender, EventArgs e) => RefreshModList();

    private void moveModToTopButton_Click(object sender, EventArgs e) => MoveModToIndex(0);

    private void moveModUpButton_Click(object sender, EventArgs e) => SwapModPositions(-1);

    private void moveModDownButton_Click(object sender, EventArgs e) => SwapModPositions(1);

    private void moveModToBottomButton_Click(object sender, EventArgs e) => MoveModToIndex(modsListView.Items.Count - 1);

    private void editButton_Click(object sender, EventArgs e)
    {
        var modInfo = modsListView.Items[modsListView.SelectedIndices[0]].Tag as ModInfo;

        using ModInfoForm form = new ModInfoForm(modInfo);

        if (form.ShowDialog() == DialogResult.OK)
        {
            ModInfo info = new();

            info.DisplayName = form.DisplayNameText;
            info.Name = form.NameText;
            info.Author = form.AuthorText;
            info.Version = form.VersionText;
            info.Tags = form.ModTags;

            modsListView.Items[modsListView.SelectedIndices[0]].Tag = info;

            ModInfo.Write(info, modInfo.Directory);

            RefreshModList();
        }
    }

    private void addModButton_Click(object sender, EventArgs e)
    {
        using ModInfoForm form = new ModInfoForm();

        if (form.ShowDialog() == DialogResult.OK)
        {
            ModInfo info = new();

            info.DisplayName = form.DisplayNameText;
            info.Name = form.NameText;
            info.Author = form.AuthorText;
            info.Version = form.VersionText;
            info.Tags = form.ModTags;

            var dir = Path.Combine(ModsDirectory, info.DisplayName);
            try
            {
                Directory.CreateDirectory(dir);
                ModInfo.Write(info, dir);
                AddMod(info);
                RefreshModList();
                Console.WriteLine($"Created mod: {info.DisplayName}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Unable to create mod", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void removeModButton_Click(object sender, EventArgs e)
    {
        var modInfo = modsListView.Items[modsListView.SelectedIndices[0]].Tag as ModInfo;

        var result = MessageBox.Show($"Are you sure you want to delete: {modInfo.DisplayName}?\nIt will be lost forever! (A really long time!)", "Delete this mod?", MessageBoxButtons.YesNo);

        if (result == DialogResult.Yes)
        {
            try
            {
                if (Directory.Exists(modInfo.Directory))
                    Directory.Delete(modInfo.Directory, true);

                modsListView.Items.RemoveAt(modsListView.SelectedIndices[0]);

                RefreshModList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured when deleting the mod:\n{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
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
        Program.Settings.WindowWidth = (uint)windowResolutionXNumericUpDown.Value;
    }

    private void windowResolutionYNumericUpDown_ValueChanged(object sender, EventArgs e)
    {
        if (_isLoading)
            return;

        Program.Settings.WindowHeight = (uint)windowResolutionYNumericUpDown.Value;
    }

    private void modsListView_ItemChecked(object sender, ItemCheckedEventArgs e)
    {
        if (_isLoading)
            return;

        RefreshConfigEnabledMods();
    }

    #endregion

    #endregion

    private void checkForUpdatesToolStripButton_Click(object sender, EventArgs e)
    {
        // V: This might block for a while, maybe do something better?
        UpdateStatus updateResult = Task.Run(async () => await UpdateManager.CheckForUpdates()).Result;

        Console.WriteLine($"Result => {updateResult.ToString()}");

        DialogResult result = DialogResult.None;


        switch (updateResult)
        {
            case UpdateStatus.AlreadyRunning:
                MessageBox.Show("An async task is already running.", "Unable to check.");
                break;
            case UpdateStatus.UpdateFound:
                result = MessageBox.Show($"An update has been found: {UpdateManager.Releases?[0].Name ?? $"<{nameof(UpdateManager.Releases)} WAS NULL PLEASE REPORT THIS!>"}, would you like to update?",
                    "Update Found",
                    MessageBoxButtons.YesNo);
                break;
            case UpdateStatus.UpToDate:
                MessageBox.Show("You are already up to date, or have a version greater than the latest release.", "Up to Date");
                break;
        }

        if (result == DialogResult.None || result == DialogResult.No)
            return;


        if (updateResult == UpdateStatus.UpdateFound && result == DialogResult.Yes)
        {
            using InstallingUpdateForm form = new InstallingUpdateForm();
            form.Show(this);
            UpdateManager.InstallUpdate();
            MessageBox.Show(form, "Install Complete.");
            form.Close();
        }

    }

}
