using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace mage.Options;

public class ProjectConfig
{
    // Add Fields here
    public Dictionary<byte, int> PrimarySpriteOAMRepoints { get; set; } = new();
    public Dictionary<byte, int> SecondarySpriteOAMRepoints { get; set; } = new();

    public bool EnableProjectCompilation { get; set; } = false;
    public string CompilationScriptPath { get; set; } = "";
    public bool CompilationIgnoreErrors { get; set; } = false;

    public bool BackupsMoveIntoSeperateDirectory { get; set; } = false;
    public string BackupDateFormatString { get; set; } = "yyyy-MM-dd_HH-mm-ss";
    public bool BackupsCreatePeriodically { get; set; } = false;
    public int BackupsAutoCreationInterval { get; set; } = 30;

    public bool SpritesetAddMoreSprites { get; set; } = false;

    public static ProjectConfig DefaultConfig { get; } = new ProjectConfig() { };


    // Constructor and Serializer Options
    [JsonConstructor]
    public ProjectConfig() { }

    private static readonly JsonSerializerOptions jsonOptions = new()
    {
        WriteIndented = false,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    };

    public static string Serialize(ProjectConfig config)
    {
        return JsonSerializer.Serialize(config, jsonOptions);
    }
    public static ProjectConfig Deserialize(string json)
    {
        return JsonSerializer.Deserialize<ProjectConfig>(json, jsonOptions) ?? new ProjectConfig();
    }

    // Function to check if the initial default config was ever changed
    private static readonly string _defaultJson = JsonSerializer.Serialize(DefaultConfig, jsonOptions);
    public static bool IsDefault(ProjectConfig config)
    {
        string configJson = JsonSerializer.Serialize(config, jsonOptions);
        return configJson.Equals(_defaultJson);
    }
}