using mage.Options.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mage.Options;

public static class PageLists
{
    private static PageAppearance AppearancePage = new();
    public static List<OptionsPage> ApplicationOptionPages = new()
    {
        new() { Name = "Appearance", Page = AppearancePage, RequiresROM = false, CustomStatusStrip = AppearancePage.CustomStrip},
        new() { Name = "Default View", Page = new PageDefaults(), RequiresROM = true },
        new() { Name = "Tools", Page = new PageRom(), RequiresROM=false },
        new() { Name = "Warnings", Page = new PageRules(), RequiresROM=false },
        new() { Name = "Soundpacks", Page = new PageSoundpacks(), RequiresROM = false },
        new() { Name = "Updates", Page = new PageUpdates(), RequiresROM = false },
        new() { Name = "Music Names", Page = new PageMusiclists(), RequiresROM=false },
        new() { Name = "Advanced", Page = new PageAdvanced(), RequiresROM=false },
    };

    public static List<OptionsPage> ProjectOptionsPages = new()
    {
        new() { Name = "Overview", Page = new PageOverview(), RequiresROM = true},
        new() { Name = "Compiling", Page = new PageCompiling(), RequiresROM = true},
        new() { Name = "Backups", Page = new PageBackups(), RequiresROM = true },
    };
}
