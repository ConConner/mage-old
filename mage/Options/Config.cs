using mage.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mage.Options;

/// <summary>
/// Application wide Config file
/// </summary>
public class Config
{
    #region Options
    public List<string> EmulatorPaths { get; set; } = new List<string>();
    public string SelectedEmulatorPath { get; set; } = string.Empty;
    public string TestRomPath { get; set; } = string.Empty;
    public bool IncludeSymbolFile { get; set; } = true;
    public bool AutomaticallyCheckForUpdates { get; set; } = true;
    public bool OnlyNotifyOnMajor { get; set; } = false;
    #endregion

    #region Rule Validator
    public bool WarningsEnabled { get; set; } = true;
    public HashSet<string> DisabledRules { get; set; } = new(StringComparer.OrdinalIgnoreCase);
    public bool IsRuleEnabled(string ruleKey) => !DisabledRules.Contains(ruleKey);
    public void SetRuleEnabled(string ruleKey, bool enabled)
    {
        if (enabled) DisabledRules.Remove(ruleKey);
        else DisabledRules.Add(ruleKey);
    }
    #endregion

    #region Pixel Image exporting
    public PixelImageColors PixelImageColors { get; set; } = new();
    #endregion

    #region Bookmarking
    public enum BookmarkCollection
    {
        Internal,
        Global,
        Project
    }
    public static void AddRecentOffset(Config config, string key, int value)
    {
        if (config.RecentOffsets.Any(item => item.Value == value))
        {
            var kvp = config.RecentOffsets.Find(item => item.Value == value);
            config.RecentOffsets.Remove(kvp);
            config.RecentOffsets.Insert(0, kvp);
            return;
        }

        config.RecentOffsets.Insert(0, new(key, value));
        if (config.RecentOffsets.Count > config.MaxRecentOffsets) config.RecentOffsets.RemoveAt(config.MaxRecentOffsets - 1);
    }

    public List<KeyValuePair<string, int>> RecentOffsets { get; set; } = new();
    public int MaxRecentOffsets { get; set; } = 10;
    public int BookmarkExpandDepth { get; set; } = 1;
    public BookmarkCollection BookmarkLastUsedCollection { get; set; } = BookmarkCollection.Internal;
    public int BookmarkLastUsedCollectionIndex { get; set; } = -1;
    #endregion

    #region Tile Table Editor
    public bool TileTableEditorShowPalettePreview { get; set; } = false;
    public bool TileTableEditorCopyPalette { get; set; } = true;
    #endregion

    #region Map Editor
    public bool MapEditorViewRoomOutlines { get; set; } = false;
    #endregion

    #region OAM Editor
    public bool OamEditorViewOrigin { get; set; } = true;
    public bool OamEditorViewPartOutlines { get; set; } = true;
    public bool OamEditorViewPalette { get; set; } = true;
    public bool OamEditorViewVram { get; set; } = false;
    public bool OamEditorLoadCommonGraphics { get; set; } = true;
    public int OamEditorGfxZoom { get; set; } = 2;
    public int OamEditorOamZoom { get; set; } = 2;
    #endregion
}