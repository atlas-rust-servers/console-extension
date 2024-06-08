using JetBrains.Annotations;

namespace Oxide.Ext.ConsoleExt;

[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public static class StringEx
{
    public static string ToColor(this string value, string color)
    {
        return string.Format(color, value);
    }
}