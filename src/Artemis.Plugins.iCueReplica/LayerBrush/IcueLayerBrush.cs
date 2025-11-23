using System;
using System.Collections.Generic;
using System.Linq;
using Artemis.Core;
using Artemis.Core.LayerBrushes;
using Artemis.Plugins.iCueReplica.Utils;
using JetBrains.Annotations;
using RGB.NET.Core;
using SkiaSharp;

namespace Artemis.Plugins.iCueReplica.LayerBrush;

[PublicAPI]
public class IcueLayerBrush(IcueService icue) : PerLedLayerBrush<IcuePropertyGroup>
{
    private static readonly int MaxLedId = Enum.GetValues<LedId>().Cast<int>().Max();
    private readonly Dictionary<LedId, SKColor> _colors = new(MaxLedId, EnumHashGetter.Instance as IEqualityComparer<LedId>);
    private bool _shouldRender;

    public override void EnableLayerBrush()
    {
        icue.GameConnected += IcueOnGameConnected;
        icue.GameDisconnected += IcueOnGameDisconnected;
        icue.ColorsUpdated += IcueOnColorsUpdated;
        _shouldRender = icue.IsConnected;
    }

    public override void DisableLayerBrush()
    {
        icue.GameConnected -= IcueOnGameConnected;
        icue.GameDisconnected -= IcueOnGameDisconnected;
        icue.ColorsUpdated -= IcueOnColorsUpdated;
        _shouldRender = false;
    }

    private void IcueOnGameConnected(object? sender, EventArgs e)
    {
        _shouldRender = true;
    }

    private void IcueOnGameDisconnected(object? sender, EventArgs e)
    {
        _shouldRender = false;
    }

    private void IcueOnColorsUpdated(object? sender, EventArgs e)
    {
        var icueColors = icue.LedColors;
        foreach (var (ledId, icueColor) in icueColors)
        {
            SKColor color = new SKColor(icueColor.R, icueColor.G, icueColor.B);
            if (IcueArtemisKeyMapping.KeyMapping.TryGetValue(ledId, out var rgbLedId))
            {
                _colors[rgbLedId] = color;
            }
        }
    }

    public override void Update(double deltaTime)
    {
    }

    public override SKColor GetColor(ArtemisLed led, SKPoint renderPoint)
    {
        if (!_shouldRender)
            return SKColor.Empty;

        if (_colors.TryGetValue(led.RgbLed.Id, out var color))
            return color;

        return SKColor.Empty;
    }
}