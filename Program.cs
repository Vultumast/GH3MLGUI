using Microsoft.Win32;
using System.Security.Principal;

namespace GH3MLGUI;

internal static class Program
{
    public const string InstallLoaderArgument = "--install-loader";
    public const string UninstallLoaderArgument = "--uninstall-loader";

    public static string GuitarHero3GameDirectory => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "Aspyr\\Guitar Hero III\\");
    public static string GuitarHero3SaveDirectory => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Aspyr\\Guitar Hero III\\");
    public static string ApplicationGH3MLDirectory => Path.Combine(Path.GetDirectoryName(Application.ExecutablePath)!, "gh3ml\\");
    public static string GameGH3MLDirectory => Path.Combine(GuitarHero3GameDirectory, "gh3ml\\");
    public static string GH3MLModDirectory => Path.Combine(GameGH3MLDirectory, "Mods\\");

    public static string VersionString => System.Reflection.Assembly.GetExecutingAssembly().GetName().Version!.ToString();
    public static GH3MLSettings Settings { get; private set; } = new();

    public static bool IsAdministrator
    {
        get
        {
            using WindowsIdentity identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }

    public static DialogResult? DisplayError(string text, MessageBoxButtons buttons = MessageBoxButtons.OK)
    {
        Console.WriteLine($"Unable to complete request: {text}");

        return MessageBox.Show(text, "Unable to complete request", buttons, MessageBoxIcon.Error);
    }

    public static bool CheckPathExists(string directory, bool throwMessageBox = false)
    {
        var exists = Path.Exists(directory);

        Console.WriteLine($"Does \"{directory}\" exist? {exists}");
        
        if (!exists && throwMessageBox )
            DisplayError($"The path \"{directory}\" does not exist.");

        return exists;
    }

    public static bool InstallLoader(string gh3Directory)
    {
        if (!CheckPathExists(ApplicationGH3MLDirectory, true))
            return false;

        var srcXInputDLLPath = Path.Combine(ApplicationGH3MLDirectory, "xinput1_3.dll");
        var srcGH3MLDLLPath = Path.Combine(ApplicationGH3MLDirectory, "gh3ml.dll");

        if (!CheckPathExists(srcXInputDLLPath, true))
            return false;
        if (!CheckPathExists(srcGH3MLDLLPath, true))
            return false;

        var dstXInputDLLPath = Path.Combine(gh3Directory, "xinput1_3.dll");
        var dstGH3MLDLLPath = Path.Combine(gh3Directory, "gh3ml.dll");

        if (CheckPathExists(dstXInputDLLPath))
            File.Delete(dstXInputDLLPath);

        if (CheckPathExists(dstGH3MLDLLPath))
            File.Delete(dstGH3MLDLLPath);

        File.Copy(srcXInputDLLPath, dstXInputDLLPath);
        File.Copy(srcGH3MLDLLPath, dstGH3MLDLLPath);

        var gh3mlPath = Path.Combine(gh3Directory, "gh3ml");

        if (!CheckPathExists(gh3mlPath))
            Directory.CreateDirectory(gh3mlPath);

        var gh3ModPath = Path.Combine(gh3Directory, "gh3ml", "Mods");

        if (!CheckPathExists(gh3ModPath))
            Directory.CreateDirectory(gh3ModPath);


        var gh3logPath = Path.Combine(gh3Directory, "gh3ml", "Logs");

        if (!CheckPathExists(gh3logPath))
            Directory.CreateDirectory(gh3logPath);

        return true;
    }
    public static bool UninstallLoader(string gh3Directory) 
    {
        var dstXInputDLLPath = Path.Combine(gh3Directory, "xinput1_3.dll");
        var dstGH3MLDLLPath = Path.Combine(gh3Directory, "gh3ml.dll");

        if (CheckPathExists(dstXInputDLLPath))
            File.Delete(dstXInputDLLPath);

        if (CheckPathExists(dstGH3MLDLLPath))
            File.Delete(dstGH3MLDLLPath);

        return true;
    }

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main(string[] args)
    {
        if (!IsAdministrator)
        {
            DisplayError("This application requires elevation.");
            return;
        }

        if (CheckPathExists(ApplicationGH3MLDirectory))
            Directory.CreateDirectory(ApplicationGH3MLDirectory);

        var configPath = Path.Combine(GameGH3MLDirectory, "config.json");

        if (!CheckPathExists(configPath) && CheckPathExists(Path.Combine(GuitarHero3GameDirectory, "gh3ml.dll")))
            GH3MLSettings.Write(Settings);

        Settings = GH3MLSettings.Read();

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());

    }
}