using ds.test.impl.Attributes;

namespace ds.test.impl.LibPlugin;

/// <summary>
/// Плагин сложения.
/// </summary>
[Version("1.1")]
public class SumPlugin : Plugin
{
    public override string Description => "plus";

    public override int Run(int input1, int input2)
    {
        base.Run(input1, input2);
        return input1 + input2;
    }
}