using JetBrains.Annotations;

namespace Oxide.Ext.ConsoleExt;

[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public interface IConsoleLogger
{
    void WriteLine(object obj, string color = OxideConsole.NORMAL);
}