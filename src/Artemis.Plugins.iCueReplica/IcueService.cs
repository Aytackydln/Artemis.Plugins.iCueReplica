using System;
using System.Collections.Generic;
using Artemis.Core.Services;
using iCUE_ReverseEngineer;
using iCUE_ReverseEngineer.Icue;
using iCUE_ReverseEngineer.Icue.Sdk;
using JetBrains.Annotations;

namespace Artemis.Plugins.iCueReplica;

public class IcueService: IPluginService
{
    public event EventHandler? GameConnected;
    public event EventHandler? GameDisconnected;
    public event EventHandler? ColorsUpdated;
    
    public bool IsConnected => _gameSdk != null;
    public Dictionary<IcueLedId,IcueColor> LedColors => _gameSdk?.LedColors ?? [];
    
    private readonly IcueServer _icue;
    private SdkHandler? _gameSdk;

    [PublicAPI]
    public IcueService()
    {
        _icue = Bootstrapper.IcueServer!;
        
        _icue.GameDisconnected += IcueOnGameDisconnected;
        _icue.GameConnected += IcueOnGameConnected;
    }

    private void IcueOnGameConnected(object? sender, GameHandler e)
    {
        _gameSdk = e.SdkHandler;
        _gameSdk.ColorsUpdated += GameSdkOnColorsUpdated;
        GameConnected?.Invoke(this, EventArgs.Empty);
    }

    private void IcueOnGameDisconnected(object? sender, GameHandler e)
    {
        if (_gameSdk != null)
            _gameSdk.ColorsUpdated -= GameSdkOnColorsUpdated;
        _gameSdk = null;
        GameDisconnected?.Invoke(this, EventArgs.Empty);
    }

    private void GameSdkOnColorsUpdated(object? sender, EventArgs e)
    {
        ColorsUpdated?.Invoke(this, e);
    }
}