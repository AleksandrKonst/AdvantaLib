namespace ds.test.impl.Factory;

/// <summary>
/// Интерфейс для управления плагинами.
/// </summary>
public interface PluginFactory
{ 
    /// <summary>
    /// Свойство содержащие колличество плагинов.
    /// </summary>
    /// <value>Колличество плагинов.</value>
    /// <remarks>Колличество классов реализующих интерфес IPlugin полученно с помощью рефлексии.</remarks>
    static int PluginsCount { get; } 
    
    /// <summary>
    /// Свойство содержащие названия плагинов.
    /// </summary>
    /// <value>Названия плагинов.</value>
    /// <remarks>Названия классов реализующих интерфес IPlugin полученно с помощью рефлексии.</remarks>
    static string[] GetPluginNames { get; }
    
    /// <summary>
    /// Получение нового экземпляра плагина по названию.
    /// </summary>
    /// <param name="pluginName">Название плагина.</param>
    /// <returns>Плагин семейства IPlugin.</returns>
    static abstract IPlugin GetPlugin (string pluginName);
}