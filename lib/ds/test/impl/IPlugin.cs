namespace ds.test.impl;

/// <summary>
/// Интерфейс плагинов.
/// </summary>
public interface IPlugin
{
    /// <summary>
    /// Свойство содержащие имя плагина.
    /// </summary>
    /// <value>Имя плагина.</value>
    string PluginName { get; }
    
    /// <summary>
    /// Свойство содержащие версия плагина.
    /// </summary>
    /// <value>версия.</value>
    string Version { get; }
    
    /// <summary>
    /// Свойство содержащие изображение плагина.
    /// </summary>
    /// <value>Изображение плагина.</value>
    /// <remarks>Type - System.Drawing.Image</remarks>
    System.Drawing.Image Image { get; }
    
    /// <summary>
    /// Свойство содержащие описание плагина.
    /// </summary>
    /// <value>Описание плагина.</value>
    string Description { get; }
    
    /// <summary>
    /// Получение нового экземпляра плагина по названию.
    /// </summary>
    /// <param name="input1">Первое число.</param>
    /// <param name="input2">Второе число</param>
    /// <returns>Результат int</returns>
    int Run (int input1, int input2);
}