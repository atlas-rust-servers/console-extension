using JetBrains.Annotations;
using Oxide.Core;
using Oxide.Core.Extensions;

namespace Oxide.Ext.ConsoleExt;

[UsedImplicitly]
public class ConsoleExt : Extension
{
    private static readonly VersionNumber s_extensionVersion = new(1, 1, 1);

    public override string Name => "ConsoleExt";
    public override string Author => "Ilovepatatos";
    public override VersionNumber Version => s_extensionVersion;

    public override bool SupportsReloading => true;

    public ConsoleExt(ExtensionManager manager) : base(manager) { }

    public override IEnumerable<string> GetPreprocessorDirectives()
    {
        yield return "CONSOLE_FRAMEWORK";
    }
}