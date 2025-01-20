using Dalamud.Configuration;
using System;

namespace AdvancedInspect;

[Serializable]
public class Configuration : IPluginConfiguration
{
    public int Version { get; set; } = 0;
}
