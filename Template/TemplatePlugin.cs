using BepInEx;
using SeLib.API;

namespace Template
{
    [BepInDependency(SeLib.PluginInfo.GUID, SeLib.PluginInfo.Version)]
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public sealed class TemplatePlugin : BaseRoR2Plugin<TemplatePlugin>;
}
