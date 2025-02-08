using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GH3MLGUI.Common;

public static class Directories
{
    /// <summary>
    /// The directory of the Guitar Hero 3 executable
    /// </summary>
    public static string GH3Directory { get; set; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "Aspyr\\Guitar Hero III\\");
    /// <summary>
    /// The directory of the Guitar Hero 3 Mod Loader
    /// </summary>
    public static string ModLoaderDirectory => Path.Combine(GH3Directory, "nylon\\");

    /// <summary>
    /// The directory where Mods will be placed
    /// </summary>
    public static string ModsDirectory => Path.Combine(ModLoaderDirectory, "Mods\\");
}
