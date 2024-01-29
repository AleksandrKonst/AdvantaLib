using ds.test.impl.Attributes;

namespace ds.test.impl.LibPlugin;

/// <summary>
/// Абстрактный класс плагинов реализующий свойства интерфейса IPlugin.
/// </summary>
[Version("1.0")]
public abstract class Plugin : IPlugin
{
    /// <summary>
    /// Конструктор Plugin
    /// </summary>
    protected Plugin()
    {
        var attribute = (VersionAttribute) Attribute.GetCustomAttribute(GetType(), typeof(VersionAttribute));
        if (attribute == null) throw new Exception("Version not found");
        Version = attribute.Version;
    }
    
    public string PluginName { get => GetType().Name; }
    
    public string Version { get; }
    
    public System.Drawing.Image Image { get => System.Drawing.Image.FromFile($"lib/ds/test/Images/{GetType().Name}.png"); }
    
    public virtual string Description { get; }
    
    public virtual int Run(int input1, int input2) => 0;
}