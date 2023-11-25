using JetBrains.Annotations;
using Oxide.Core;
using Oxide.Core.Extensions;

namespace Oxide.Ext.ConsoleExt
{
    [UsedImplicitly]
    public class ConsoleExt : Extension
    {
        private static readonly VersionNumber s_ExtensionVersion = new(1, 0, 0);

        public override string Name => "ConsoleExt";
        public override string Author => "Ilovepatatos";
        public override VersionNumber Version => s_ExtensionVersion;

        public override bool SupportsReloading => true;

        public ConsoleExt(ExtensionManager manager) : base(manager) { }
    }
}