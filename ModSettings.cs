using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GH3MLGUI;

public class ModSettings
{
    [JsonPropertyName("Name")]
    public string Name { get; set; } = "axelsteel.newmod";

    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; } = "My Mod";

    [JsonPropertyName("description")]
    public string Description { get; set; } = "GH3 Modding in 2025??";

    [JsonPropertyName("version")]
    public string Version { get; set; } = "1.0.0.0";

    // Reserved
    [JsonPropertyName("updateLink")]
    public string UpdateLink { get; set; } = "";


    [JsonPropertyName("paksToReplace")]
    public Dictionary<string, string> PaksToReplace { get; set; } = new Dictionary<string, string>();

    [JsonPropertyName("paksToLoad")]
    public string[] PaksToLoad { get; set; } = Array.Empty<string>();

    public static ModSettings Read(string path) => JsonSerializer.Deserialize<ModSettings>(File.ReadAllText(path))!;
   
    public static void Write(ModSettings settings, string directory) => File.WriteAllText(Path.Combine(directory, "modinfo.json"), JsonSerializer.Serialize(settings, new JsonSerializerOptions() { WriteIndented = true }));
    
}
