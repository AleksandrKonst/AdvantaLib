using ds.test.impl.Attributes;

namespace ds.test.impl.LibPlugin;

/// <summary>
/// Плагин умножения.
/// </summary>
[Version("1.3")]
public class MultPlugin : Plugin
{
    public override string Description => "multiplication";

    public override int Run(int input1, int input2)
    {
        base.Run(input1, input2);
        return input1 * input2;
    }
}