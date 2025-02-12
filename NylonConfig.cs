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

public class VersionInfo
{

    [JsonPropertyName("major")]
    public int MajorVersion { get; set; } = 0;
    [JsonPropertyName("minor")]
    public int MinorVersion { get; set; } = 0;
    [JsonPropertyName("revision")]
    public int RevisionVersion { get; set; } = 0;
    [JsonPropertyName("type")]
    public int VersionType { get; set; } = 0;

    [JsonIgnore]
    public uint VersionInt => ((uint)MajorVersion * 1000u) + ((uint)MinorVersion * 100u) + ((uint)RevisionVersion * 10u) + (uint)VersionType;

    public static VersionInfo FromString(string versionString)
    {
        VersionInfo info = new();

        string[] stringInfo = versionString.Substring(0, versionString.Length - 1).Split('.', StringSplitOptions.RemoveEmptyEntries);
        int outTemp = 0;

        if (!int.TryParse(stringInfo[0], out outTemp))
            info.MajorVersion = 0;
        else
            info.MajorVersion = outTemp;

        if (!int.TryParse(stringInfo[1], out outTemp))
            info.MinorVersion = 0;
        else
            info.MinorVersion = outTemp;

        if (!int.TryParse(stringInfo[2], out outTemp))
            info.RevisionVersion = 0;
        else
            info.RevisionVersion = outTemp;

        info.VersionType = versionString[versionString.Length - 1] switch
        {
            'a' => 0,
            'A' => 0,
            'b' => 1,
            'B' => 1,
            'r' => 100,
            'R' => 100,
            _ => -1
        };

        return info;
    }
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

    [JsonPropertyName("windowWidth")]
    public uint WindowWidth { get; set; } = 1920;
    [JsonPropertyName("windowHeight")]
    public uint WindowHeight { get; set; } = 1080;

    [JsonPropertyName("enabledMods")]
    public string[] EnabledMods { get; set; } = Array.Empty<string>();

    [JsonPropertyName("versionInfo")]
    public VersionInfo VersionInfo { get; set; } = new();
    public static NylonConfig Read() => JsonSerializer.Deserialize<NylonConfig>(File.ReadAllText(Path.Combine(ModLoaderDirectory, "config.json")))!;
  
    public static void Write(NylonConfig settings) => File.WriteAllText(Path.Combine(ModLoaderDirectory, "config.json"), JsonSerializer.Serialize(settings, new JsonSerializerOptions() { WriteIndented = true }));
    
}
