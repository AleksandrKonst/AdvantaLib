using ds.test.impl.Factory;

namespace ds.test.impl;

/// <summary>
/// Общий класс для управления плагинами.
/// </summary>
public class Plugins : PluginFactory
{
    public static int PluginsCount
    {
        get { return typeof(Plugins).Assembly
            .GetTypes()
            .Count(t => t.GetInterfaces().Contains(typeof(IPlugin))); }
    }
    
    public static string[] GetPluginNames
    {
        get { return typeof(Plugins).Assembly
            .GetTypes()
            .Where(t => t.GetInterfaces().Contains(typeof(IPlugin)))
            .Select(c => c.Name).ToArray(); } 
    }
    
    public static IPlugin GetPlugin(string pluginName)
    {
        var plugin = typeof(Plugins).Assembly
            .GetTypes()
            .FirstOrDefault(t => t.GetInterfaces().Contains(typeof(IPlugin)) && t.Name == pluginName);

        if (plugin == null) throw new Exception("Plugin not found");
        
        var instance = (IPlugin)Activator.CreateInstance(plugin);
        
        if (instance == null) throw new Exception("Internal Error");
        
        return instance;
    }
}