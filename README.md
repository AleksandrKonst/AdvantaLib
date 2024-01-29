# lib.dll
## ТЗ
- Проект при компиляции должен формировать файл-библиотеку с именем `lib.dll`
- `Namespace` по умолчанию `ds.test.impl`
- При подключении данной библиотеки в данном Namespace должны быть доступны 1 интерфейс `IPlugin` и один статический класс `Plugins`:

```c#
public interface IPlugin
{
 string PluginName { get; }
 string Version { get; }
 System.Drawing.Image Image { get; }
 string Description { get; }
 int Run (int input1, int input2);
}
```
- Статический класс `Plugins` должен реализовывать интерфейс:

```c#
interface PluginFactory
{
  int PluginsCount { get; }
  string[] GetPluginNames { get; }
  IPlugin GetPlugin (string pluginName);
}
```
- Часть реализаций интерфейса `IPlugin` должна быть унаследована от закрытого абстрактного
класса.
- Метод `Run` должен реализовывать различные математические функции (сложение умножение и
т.п. их количество зависит от Вашего желания помочь экипажу)
- Библиотека должна работать стабильно, должны быть реализованы все необходимые проверки,
должно использоваться документирование, так чтобы ни у кого не возникло вопросов как
пользоваться данной библиотекой.
- В реализации интерфейсов допускается, но не рекомендуется использование сторонних
библиотек.

## Test
Проверка в консольном приложении
```c#
using ds.test.impl;

Console.WriteLine(Plugins.PluginsCount);
foreach (var src in Plugins.GetPluginNames)
{
    Console.WriteLine(src);
}

Console.WriteLine();

var plug = Plugins.GetPlugin("SumPlugin");
Console.WriteLine(plug.PluginName);
Console.WriteLine(plug.Version);
Console.WriteLine(plug.Description);
Console.WriteLine(plug.Run(1, 2));

Console.WriteLine();

var mult = Plugins.GetPlugin("MultPlugin");
Console.WriteLine(mult.PluginName);
Console.WriteLine(mult.Version);
Console.WriteLine(mult.Description);
Console.WriteLine(mult.Run(1, 2));
```

![image](https://github.com/AleksandrKonst/AdvantaLib/assets/40522320/bbd5d389-7dc5-407c-ad5d-0775c68121c0)
