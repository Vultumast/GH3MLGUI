using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Security.Principal;

namespace GH3MLGUI;

public partial class MainForm : Form
{
    public static void OpenDirectory(string path) => Process.Start("explorer.exe", path);


    public Dictionary<string, (string path, ModSettings settings)> ModList { get; private set; } = new Dictionary<string, (string path, ModSettings settings)>();


    public void RefreshModList()
    {
        if (!Directory.Exists(Program.GH3MLModDirectory))
            Directory.CreateDirectory(Program.GH3MLModDirectory);

        // TODO: SAVE UNCHECKED MOD MOVEMENT

        ModList.Clear();

        modCheckedListBox.Items.Clear();
        modCheckedListBox.Tag = Array.Empty<string>();

        var directories = Directory.GetDirectories(Program.GH3MLModDirectory);

        foreach (var dir in directories)
        {
            var modInfoPath = Path.Combine(dir, "modinfo.json");

            if (!Program.CheckPathExists(modInfoPath))
                continue;

            var settings = ModSettings.Read(modInfoPath);

            ModList.Add(settings.Name, (modInfoPath, settings));
        }

        // TODO: reorder some stuff?

        modCheckedListBox.Tag = new string[ModList.Count];
        string[]? modCheckedListNames = modCheckedListBox.Tag as string[];
        int indexer = 0;
        foreach (var kv in ModList)
        {
            modCheckedListBox.Items.Add(kv.Value.settings.DisplayName);
            modCheckedListNames![indexer++] = kv.Key;
        }



        foreach (var enabledMod in Program.Settings.EnabledMods)
        {
            var index = Array.IndexOf(modCheckedListNames!, enabledMod);

            if (index != -1)
                modCheckedListBox.SetItemChecked(index, true);
        }
    }


    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        versionToolStripLabel.Text = $"GUI v{Program.VersionString}";
        if (Path.Exists(Path.Combine(Program.GuitarHero3GameDirectory, "gh3ml.dll")))
        {
            installLoaderToolStripButton.Text = "Uninstall Loader";
            installLoaderToolStripButton.Tag = true;
        }
        else
        {

            installLoaderToolStripButton.Text = "Install Loader";
            installLoaderToolStripButton.Tag = false;
        }

        var dirToDisplay = Program.GuitarHero3GameDirectory;

        if (dirToDisplay.StartsWith(Environment.GetEnvironmentVariable("ProgramFiles(x86)")!))
            dirToDisplay = "%ProgramFiles(x86)%\\Aspyr\\Guitar Hero III\\";

        gamePathLinkLabel.Text = $"Game Path: {dirToDisplay}";

        dirToDisplay = Program.GuitarHero3SaveDirectory;

        if (dirToDisplay.StartsWith(Environment.GetEnvironmentVariable("LocalAppData")!))
            dirToDisplay = "%LocalAppData%\\Aspyr\\Guitar Hero III\\";

        savePathLinkLabel.Text = $"Save Path: {dirToDisplay}";

        modCheckedListBox.Tag = Array.Empty<string>();
        RefreshModList();
    }


    #region Toolstrip
    private void installLoaderToolStripButton_Click(object sender, EventArgs e)
    {
        if (sender is not ToolStripButton control)
            return;

        if ((bool)(control?.Tag ?? false))
        {
            Program.UninstallLoader(Program.GuitarHero3GameDirectory);
            installLoaderToolStripButton.Text = "Install Loader";
            installLoaderToolStripButton.Tag = false;
        }
        else
        {
            Program.InstallLoader(Program.GuitarHero3GameDirectory);
            installLoaderToolStripButton.Text = "Uninstall Loader";
            installLoaderToolStripButton.Tag = true;
        }
    }

    private void saveToolStripButton_Click(object sender, EventArgs e)
    {
        Program.Settings.EnabledMods = Array.Empty<string>();

        List<string> enabledMods = new();
        for (var i = 0; i < modCheckedListBox.Items.Count; i++)
        {
            if (modCheckedListBox.GetItemChecked(i))
                enabledMods.Add(((string[])modCheckedListBox.Tag!)[i]);
        }


        Program.Settings.EnabledMods = enabledMods.ToArray();

        GH3MLSettings.Write(Program.Settings);
    }

    private void settingsToolStripButton_Click(object sender, EventArgs e)
    {
        using SettingsForm form = new SettingsForm();

        form.OpenGH3Console = Program.Settings.OpenGH3Console;
        form.AllowQScriptPrintf = Program.Settings.AllowQScriptPrintf;
        form.ModLogType = Program.Settings.ModLogType;
        form.WindowStyle = Program.Settings.WindowStyle;

        if (form.ShowDialog() == DialogResult.OK)
        {
            Program.Settings.OpenGH3Console = form.OpenGH3Console;
            Program.Settings.AllowQScriptPrintf = form.AllowQScriptPrintf;
            Program.Settings.ModLogType = form.ModLogType;
            Program.Settings.WindowStyle = form.WindowStyle;

            GH3MLSettings.Write(Program.Settings);
        }
    }

    private void aboutToolStripButton_Click(object sender, EventArgs e)
    {
        using AboutForm form = new();

        form.ShowDialog();
    }
    #endregion

    #region Mod Context Menu
    private void pluginContextMenuStrip_Opening(object sender, CancelEventArgs e)
    {
        var index = modCheckedListBox.IndexFromPoint(modCheckedListBox.PointToClient(MousePosition));

        if (index != -1)
            modCheckedListBox.SelectedIndex = index;

        moveModUpToolStripMenuItem.Enabled = index != -1 && modCheckedListBox.Items.Count > 1 && index > 0;
        moveModDownToolStripMenuItem.Enabled = index != -1 && modCheckedListBox.Items.Count > 1 && index < modCheckedListBox.Items.Count - 1;
    }

    private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
    {
        RefreshModList();
    }

    private void MoveModIndex(int index, int sign)
    {
        var itemA = modCheckedListBox.Items[modCheckedListBox.SelectedIndex];
        var itemB = modCheckedListBox.Items[modCheckedListBox.SelectedIndex + Math.Sign(sign)];

        modCheckedListBox.Items[modCheckedListBox.SelectedIndex] = itemB;
        modCheckedListBox.Items[modCheckedListBox.SelectedIndex + Math.Sign(sign)] = itemA;
    }

    private void moveModUpToolStripMenuItem_Click(object sender, EventArgs e) => MoveModIndex(modCheckedListBox.SelectedIndex, -1);

    private void moveModDownToolStripMenuItem_Click(object sender, EventArgs e) => MoveModIndex(modCheckedListBox.SelectedIndex, 1);
    #endregion

    #region Link Labels
    private void gamePathLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => OpenDirectory(Program.GuitarHero3GameDirectory);

    private void savePathLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => OpenDirectory(Program.GuitarHero3SaveDirectory);
    #endregion


    private void launchGH3Button_Click(object sender, EventArgs e)
    {
        ProcessStartInfo gh3Info = new();
        gh3Info.FileName = Path.Combine(Program.GuitarHero3GameDirectory, "gh3.exe");
        gh3Info.UseShellExecute = true;

        Process.Start(gh3Info);
        Application.Exit();
    }

    private void checkForLoaderUpdatesToolStripButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show("TODO: THIS");
    }
}
