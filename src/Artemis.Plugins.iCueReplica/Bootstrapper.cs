using Artemis.Core;
using iCUE_ReverseEngineer.Icue;
using JetBrains.Annotations;

namespace Artemis.Plugins.iCueReplica;

[PublicAPI]
public class Bootstrapper : PluginBootstrapper
{
    // probably should use Artemis's dependency injection instead of static
    public static IcueServer? IcueServer { get; private set; }

    public override void OnPluginLoaded(Plugin plugin)
    {
    }

    public override void OnPluginEnabled(Plugin plugin)
    {
        IcueServer = new IcueServer();
        IcueServer.Run();
    }
    
    public override void OnPluginDisabled(Plugin plugin)
    {
        if (IcueServer == null) return;
        IcueServer.Dispose();
        IcueServer = null;
    }
}
