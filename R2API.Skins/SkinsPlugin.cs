using BepInEx;
using BepInEx.Logging;
using System;

[assembly: HG.Reflection.SearchableAttribute.OptIn]

namespace R2API;

[BepInPlugin(Skins.PluginGUID, Skins.PluginName, Skins.PluginVersion)]
public sealed class SkinsPlugin : BaseUnityPlugin
{
    internal static new ManualLogSource Logger { get; set; }

    private void Awake()
    {
        Logger = base.Logger;
    }

    private void OnEnable()
    {
        Skins.SetHooks();
        SkinIDRS.SetHooks();
        SkinVFX.SetHooks();
    }

    private void OnDisable()
    {
        Skins.UnsetHooks();
        SkinIDRS.UnsetHooks();
        SkinVFX.UnsetHooks();
        SkinLightReplacement.UnsetHooks();
    }
}
