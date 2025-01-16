using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.CodeDom;

namespace GH3MLGUI;

public enum LogTypes
{
    None,
    Trace,
    Debug,
    Info,
    Warn,
    Error,
}
public enum WindowStyles
{
    Fullscreen,
    Windowed,
    BorderlessWindowed,
    BorderlessFullscreen
}

public class GH3MLSettings
{
    [JsonPropertyName("openGH3Console")]
    public bool OpenGH3Console { get; set; } = true;

    [JsonPropertyName("allowQScriptPrintf")]
    public bool AllowQScriptPrintf { get; set; } = true;

    [JsonPropertyName("windowStyle")]
    public WindowStyles WindowStyle { get; set; } = WindowStyles.Windowed;

    [JsonPropertyName("pluginLogType")]
    public LogTypes ModLogType { get; set; } = LogTypes.Trace;

    public string[] EnabledMods { get; set; } = Array.Empty<string>();

    public static GH3MLSettings Read() => JsonSerializer.Deserialize<GH3MLSettings>(File.ReadAllText(Path.Combine(Program.GameGH3MLDirectory, "config.json")))!;
  
    public static void Write(GH3MLSettings settings) => File.WriteAllText(Path.Combine(Program.GameGH3MLDirectory, "config.json"), JsonSerializer.Serialize(settings, new JsonSerializerOptions() { WriteIndented = true }));
    
}
