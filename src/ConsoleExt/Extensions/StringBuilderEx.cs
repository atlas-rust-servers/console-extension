using System.Text;
using JetBrains.Annotations;

namespace Oxide.Ext.ConsoleExt;

[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public static class StringBuilderEx
{
    public static void Append(this StringBuilder sb, string value, string color)
    {
        sb.Append(value.ToColor(color));
    }

    public static void AppendLine(this StringBuilder sb, string value, string color)
    {
        sb.AppendLine(value.ToColor(color));
    }
}