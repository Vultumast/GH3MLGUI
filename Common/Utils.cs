using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace GH3MLGUI.Common;

public static class Utils
{
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

        if (!exists && throwMessageBox)
            DisplayError($"The path \"{directory}\" does not exist.");

        return exists;
    }
}
