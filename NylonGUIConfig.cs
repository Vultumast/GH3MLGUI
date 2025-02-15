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

public class NylonGUIConfig
{
    [JsonPropertyName("gh3Directory")]
    public string GH3Directory { get; set; } = "C:/Program Files (x86)/Aspyr/Guitar Hero III";
    
    public static NylonGUIConfig Read() => JsonSerializer.Deserialize<NylonGUIConfig>(File.ReadAllText("config.json"))!;
  
    public static void Write(NylonGUIConfig settings) => File.WriteAllText("config.json", JsonSerializer.Serialize(settings, new JsonSerializerOptions() { WriteIndented = true }));
}