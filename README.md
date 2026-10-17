# Quarry

This mod adds a quarry for collecting rocks and resources in flat terrain.

![Preview](https://raw.githubusercontent.com/Benjamin-S/Quarry/master/About/Preview.PNG)


Forked from the awesome https://github.com/cuproPanda/Quarry and updated for Rimworld 1.0.

Steam Workshop: https://steamcommunity.com/sharedfiles/filedetails/?id=1543177113

## Supported versions

| RimWorld | Folder | Assembly built against |
|----------|--------|------------------------|
| 1.7 | `1.7` | .NET 10 (Waylith), Harmony 3.0 |
| 1.6 | `1.6` | .NET Framework 4.7.2 (Mono/Unity), Harmony 2.3 |
| 1.0 – 1.5 | `1.0` … `1.5` | prebuilt, no longer maintained |

`LoadFolders.xml` maps every game version to its own folder. Harmony is a mod dependency (`brrainz.harmony`) and is not shipped for 1.7.

## Building

The source for 1.6 and 1.7 lives in `Source/Quarry`. One SDK-style project builds both assemblies:

```
dotnet build -c Release
```

Run it from the repository root (or from `Source/Quarry`). It needs the .NET 10 SDK and writes

- `1.6/Assemblies/Quarry.dll` (`net472`, references from the NuGet package `Krafs.Rimworld.Ref` 1.6.4871 and `Lib.Harmony`)
- `1.7/Assemblies/Quarry.dll` (`net10.0`, references `Assembly-CSharp.dll`, `UnityStubs.dll`, `Waylith.dll` and `Waylith.UnityCompat.dll` from the RimWorld 1.7 install, plus `0Harmony.dll` from the Harmony mod's `1.7/Assemblies` folder)

By default the 1.7 build looks for the game in `C:\Program Files (x86)\Steam\steamapps\common\RimWorld` and for Harmony in the Steam Workshop folder next to it (`workshop\content\294100\2009463077`). Other locations:

```
dotnet build -c Release -p:RimWorldDir="D:\Games\RimWorld" -p:Harmony17Dir="D:\Mods\Harmony\1.7\Assemblies"
```

`RimWorldDir` can also be set with the `RIMWORLD_DIR` environment variable. Without a RimWorld 1.7 install, build only the 1.6 assembly:

```
dotnet build -c Release -p:TargetFramework=net472
```

The Defs and Patches in `1.6` and `1.7` are separate copies; change both when fixing XML that applies to both versions.
