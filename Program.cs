using GH3MLGUI.Common;
using Microsoft.Win32;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using System.Security.AccessControl;
using System.Security.Principal;

using static GH3MLGUI.Common.Directories;
using static GH3MLGUI.Common.ProgramArguments;
using static GH3MLGUI.Common.Utils;

namespace GH3MLGUI;

public enum ErrorCode
{
    ERROR_SUCCESS = 0x0,

    ERROR_CANCELLED = 0x4C7,

    ERROR_PRIVILEGE_NOT_HELD = 0x521
}
internal static class Program
{
    
    public static string GuitarHero3SaveDirectory => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Aspyr\\Guitar Hero III\\");
    public static string VersionString => System.Reflection.Assembly.GetExecutingAssembly().GetName().Version!.ToString();
    public static NylonConfig Settings { get; private set; } = new();

    // I stold this from https://stackoverflow.com/questions/1410127/c-sharp-test-if-user-has-write-access-to-a-folder

    /// <summary>
    /// Test a directory for create file access permissions
    /// </summary>
    /// <param name="DirectoryPath">Full path to directory </param>
    /// <param name="AccessRight">File System right tested</param>
    /// <returns>State [bool]</returns>
    public static bool DirectoryHasPermission(string DirectoryPath, FileSystemRights AccessRight)
    {
        if (string.IsNullOrEmpty(DirectoryPath)) return false;

        try
        {
            AuthorizationRuleCollection rules = (new DirectoryInfo(DirectoryPath)).GetAccessControl().GetAccessRules(true, true, typeof(System.Security.Principal.SecurityIdentifier));
            WindowsIdentity identity = WindowsIdentity.GetCurrent();

            foreach (FileSystemAccessRule rule in rules)
            {
                if (identity.Groups.Contains(rule.IdentityReference))
                {
                    if ((AccessRight & rule.FileSystemRights) == AccessRight)
                    {
                        if (rule.AccessControlType == AccessControlType.Allow)
                            return true;
                    }
                }
            }
        }
        catch { }
        return false;
    }

    public static bool CanWriteToGH3Directory()
    {
        if (IsAdministrator)
            return true;

        return DirectoryHasPermission(GH3Directory, FileSystemRights.WriteData | FileSystemRights.CreateDirectories);
    }

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static int Main(string[] args)
    {
        /*var octokitclient = new Octokit.GitHubClient(new Octokit.ProductHeaderValue("gh3mlgui"));
        IReadOnlyList<Octokit.Release> releases = octokitclient.Repository.Release.GetAll("Vultumast", "gh3ml").Result;

        foreach (var release in releases)
        {
            Console.WriteLine(release.Name);
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.UserAgent.Add(new System.Net.Http.Headers.ProductInfoHeaderValue("ghmlgui", "1"));

                using (var s = client.GetStreamAsync(release.ZipballUrl))
                {
                    using (var fs = new FileStream("release.zip", FileMode.OpenOrCreate))
                    {
                        s.Result.CopyTo(fs);
                    }
                }
            }
        }*/

        if (!CanWriteToGH3Directory())
        {
            if (DisplayError("Your Guitar Hero 3 directory does not have Anonymous access rights, would you like them to be enabled?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Process proc = new Process();
                proc.StartInfo.FileName = Process.GetCurrentProcess().ProcessName;
                proc.StartInfo.UseShellExecute = true;
                proc.StartInfo.Verb = "runas";
                proc.StartInfo.ArgumentList.Add(SetAccessArgument);
                proc.Start();
            }
            else
                return (int)ErrorCode.ERROR_CANCELLED;
        }

        if (args.Length == 0)
        {
            if (CheckPathExists(ModLoaderDirectory))
                Directory.CreateDirectory(ModLoaderDirectory);

            var configPath = Path.Combine(ModLoaderDirectory, "config.json");

            if (!CheckPathExists(configPath) && CheckPathExists(Path.Combine(GH3Directory, "nylon.dll")))
                NylonConfig.Write(Settings);

            Settings = NylonConfig.Read();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Forms.MainForm());

            return (int)ErrorCode.ERROR_SUCCESS;
        }

        ParseArguments(args);

        return (int)ErrorCode.ERROR_SUCCESS;

    }

    private static void Program_OutputDataReceived(object sender, DataReceivedEventArgs e)
    {

    }
}