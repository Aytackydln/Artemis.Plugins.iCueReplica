using Artemis.Core.LayerBrushes;

namespace Artemis.Plugins.iCueReplica.LayerBrush;

public class IcueLayerBrushProvider : LayerBrushProvider
{
    public override void Enable()
    {
        RegisterLayerBrushDescriptor<IcueLayerBrush>("iCUE Integration Layer", "Display iCUE integration colors", "Robber");
    }

    public override void Disable()
    {
    }
}