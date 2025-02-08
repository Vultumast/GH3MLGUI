using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GH3MLGUI;

[Flags]
public enum ModTag
{
    Unspecified = 0x0000,
    Highway     = 0x0001,
    Song        = 0x0002,
    Model       = 0x0004,
    Gameplay    = 0x0008,
    BugFix      = 0x0010,
    Performance = 0x0020,
    UI          = 0x0040,
    Utility     = 0x0080,
    Joke        = 0x0100,
    Paid        = 0x0200,
}

public class ModInfo
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = "axelsteel.newmod";

    [JsonPropertyName("author")]
    public string Author { get; set; } = "Axel Steel";


    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; } = "My Mod";

    [JsonPropertyName("description")]
    public string Description { get; set; } = "GH3 Modding in 2025??";

    [JsonPropertyName("version")]
    public string Version { get; set; } = "1.0.0.0";

    // Reserved
    [JsonPropertyName("updateLink")]
    public string UpdateLink { get; set; } = "";

    [JsonPropertyName("paksToLoad")]
    public string[] PaksToLoad { get; set; } = Array.Empty<string>();

    [JsonPropertyName("paksToReplace")]
    public Dictionary<string, string> PaksToReplace { get; set; } = new Dictionary<string, string>();

    [JsonPropertyName("tags")]
    public ModTag Tags { get; set; } = ModTag.Unspecified;
    public static bool TryRead(string path, out ModInfo? info)
    {
        try
        {
            info = JsonSerializer.Deserialize<ModInfo>(File.ReadAllText(path))!;
            return true;
        }
        catch (Exception ex)
        {
            info = null;
            Console.WriteLine(ex.Message);
            return false;
        }
    }
    public static ModInfo Read(string path) => JsonSerializer.Deserialize<ModInfo>(File.ReadAllText(path))!;
   
    public static void Write(ModInfo settings, string directory) => File.WriteAllText(Path.Combine(directory, "modinfo.json"), JsonSerializer.Serialize(settings, new JsonSerializerOptions() { WriteIndented = true }));
    
}
