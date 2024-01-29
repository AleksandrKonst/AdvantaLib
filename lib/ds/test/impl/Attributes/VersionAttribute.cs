namespace ds.test.impl.Attributes;

/// <summary>
/// Атрибут версии плагина.
/// </summary>
/// <param name="version">Версия плагина.</param>
public class VersionAttribute(string version) : Attribute
{
    /// <summary>
    /// Свойство версии плагина.
    /// </summary>
    /// <value>Версия плагина.</value>
    public string Version { get; set; } = version;
}