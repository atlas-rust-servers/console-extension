using JetBrains.Annotations;
using Oxide.Core.Plugins;
using Oxide.Ext.ConsoleExt;

namespace Oxide.Plugins
{
    [Info("(Sample) ConsoleExt", "Ilovepatatos", "1.0.0")]
    public class ConsoleExtSample : CovalencePlugin
    {
        [UsedImplicitly]
        [HookMethod(nameof(OnServerInitialized))]
        private void OnServerInitialized(bool initial)
        {
            OxideConsole.Log("[(Sample) ConsoleExt] Console works!", OxideConsole.GREEN);
        }
    }
}