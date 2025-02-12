using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GH3MLGUI;

public enum UpdateStatus
{
    NotSet,
    AlreadyRunning,
    UpdateFound,
    UpToDate
}

public static class UpdateManager
{
    public static volatile bool CheckingForUpdates = false;

    public static volatile IReadOnlyList<Octokit.Release>? Releases = null;

    public static async Task<UpdateStatus> CheckForUpdates()
    {
        if (CheckingForUpdates)
        {
            Console.WriteLine("Can't check for updates, a process is already checking!");
            return UpdateStatus.AlreadyRunning;
        }
        CheckingForUpdates = true;

        Console.WriteLine("Checking for Updates...");

        var octokitclient = new Octokit.GitHubClient(new Octokit.ProductHeaderValue("nylongui"));

        Releases = await octokitclient.Repository.Release.GetAll("nsneverhax", "nylon");

        var latestRelease = Releases[0];

        VersionInfo info = VersionInfo.FromString(latestRelease.TagName);

        if (info.VersionInt <= Program.Settings.VersionInfo.VersionInt)
        {
            Console.WriteLine($"Up to date.");
            CheckingForUpdates = false;
            return UpdateStatus.UpToDate;
        }
        Console.WriteLine($"Found Update: {latestRelease.Name}");

        Console.WriteLine($"Found latest release with tag: {latestRelease.TagName}");
        Console.WriteLine($"Found latest release with info: {info.MajorVersion}.{info.MinorVersion}.{info.RevisionVersion} {info.VersionType}");

        CheckingForUpdates = false;

        return UpdateStatus.UpdateFound;
    }

    public static void InstallUpdate()
    {
        if (Releases is null)
        {
            Console.WriteLine("Unable to install an update. Releases was null!");
            return;
        }

        Console.WriteLine($"Installing update: {Releases[0].Name}");

        using HttpClient httpClient = new HttpClient();


        httpClient.DefaultRequestHeaders.UserAgent.Add(new System.Net.Http.Headers.ProductInfoHeaderValue("NylonGUI", "1"));

        Console.WriteLine(Releases[0].Assets[0].BrowserDownloadUrl);

        using Task<Stream>? stream = httpClient.GetStreamAsync(Releases[0].Assets[0].BrowserDownloadUrl);

        var zipPath = Path.Combine(TemporaryManager.TempDirectory, "release.zip");

        using FileStream fileStream = new(Path.Combine(zipPath), System.IO.FileMode.OpenOrCreate);
        stream.Result.CopyTo(fileStream);

        fileStream.Close();
        stream.Result.Close();


        System.IO.Compression.ZipFile.ExtractToDirectory(zipPath, Common.Directories.GH3Directory);

        File.Delete(zipPath);
    }
}
