using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.CodeDom;

using static GH3MLGUI.Common.Directories;

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
public enum WindowStyle
{
    Fullscreen,
    Windowed,
    BorderlessWindowed,
    BorderlessFullscreen
}

public class NylonConfig
{
    [JsonPropertyName("openGH3Console")]
    public bool OpenGH3Console { get; set; } = true;

    [JsonPropertyName("allowQScriptPrintf")]
    public bool AllowQScriptPrintf { get; set; } = true;

    [JsonPropertyName("windowStyle")]
    public WindowStyle WindowStyle { get; set; } = WindowStyle.Windowed;

    [JsonPropertyName("pluginLogType")]
    public LogTypes ModLogType { get; set; } = LogTypes.Trace;

    [JsonPropertyName("vsync")]
    public bool VSync { get; set; } = true;

    [JsonPropertyName("windowSize")]
    public Size WindowSize { get; set; } = new Size(1920, 1080);

    public string[] EnabledMods { get; set; } = Array.Empty<string>();

    public static NylonConfig Read() => JsonSerializer.Deserialize<NylonConfig>(File.ReadAllText(Path.Combine(GH3Directory, "config.json")))!;
  
    public static void Write(NylonConfig settings) => File.WriteAllText(Path.Combine(GH3Directory, "config.json"), JsonSerializer.Serialize(settings, new JsonSerializerOptions() { WriteIndented = true }));
    
}
