using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GH3MLGUI;

public class TemporaryManager
{
    private static string s_tempDirectory = string.Empty;

    public static string TempDirectory
    {
        get
        {
            if (s_tempDirectory == string.Empty)
            {
                s_tempDirectory = Path.GetRandomFileName();

                s_tempDirectory = Path.Combine(Path.GetTempPath(), $"NylonGUI_{s_tempDirectory.Substring(0, s_tempDirectory.Length - 4)}");
            }

            return s_tempDirectory;
        }
    }

    public static void Init()
    {
        Directory.CreateDirectory(TempDirectory);
    }

    public static void Cleanup()
    {
        // V: No exceptions for me thank you.
        try
        {
            Directory.Delete(TempDirectory, true);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unable to cleanup temporary directory! {ex.Message}");
        }
    }
}
