using System;
using System.Collections.Generic;
using System.Linq;
using Artemis.Core.Modules;
using Artemis.Core.Services;
using Artemis.Plugins.iCueReplica.DataModels;
using iCUE_ReverseEngineer.Icue;
using iCUE_ReverseEngineer.Icue.Gsi;
using JetBrains.Annotations;

namespace Artemis.Plugins.iCueReplica;

[PublicAPI]
public class IcueGsiModule : Module<IcueGameStateData>
{

    public override void Enable()
    {
        Bootstrapper.IcueServer!.GameConnected += IcueServerOnGameConnected;
        Bootstrapper.IcueServer.GameDisconnected += IcueServerOnGameDisconnected;
    }

    private void IcueServerOnGameConnected(object? sender, GameHandler e)
    {
        var gsiHandler = e.GsiHandler;
        gsiHandler.StateAdded += GsiHandlerOnStateAdded;
        gsiHandler.StateRemoved += GsiHandlerOnStateRemoved;
        gsiHandler.StatesCleared += GsiHandlerOnStatesCleared;
        
        gsiHandler.EventAdded += GsiHandlerOnEventAdded;
        gsiHandler.EventsCleared += GsiHandlerOnEventsCleared;

        var gamePid = e.GamePid;
        var processInfo = ProcessMonitor.Processes.FirstOrDefault(p => p.ProcessId == gamePid);
        DataModel.ConnectedGame = processInfo.ProcessName;
        DataModel.IsGameConnected = true;
    }

    private void IcueServerOnGameDisconnected(object? sender, GameHandler e)
    {
        Reset();
    }

    private void GsiHandlerOnStateAdded(object? sender, IcueStateEventArgs e)
    {
        DataModel.GameStates.Add(e.StateName);
    }

    private void GsiHandlerOnStateRemoved(object? sender, IcueStateEventArgs e)
    {
        DataModel.GameStates.Remove(e.StateName);
    }

    private void GsiHandlerOnStatesCleared(object? sender, EventArgs e)
    {
        DataModel.GameStates.Clear();
    }

    private void GsiHandlerOnEventAdded(object? sender, IcueStateEventArgs e)
    {
        DataModel.GameEvents.Add(e.StateName);
        DataModel.OnGameEventTriggered(e.StateName);
    }

    private void GsiHandlerOnEventsCleared(object? sender, EventArgs e)
    {
        DataModel.GameEvents.Clear();
    }

    public override void Disable()
    {
        Bootstrapper.IcueServer!.GameConnected -= IcueServerOnGameConnected;
        Bootstrapper.IcueServer.GameDisconnected -= IcueServerOnGameDisconnected;
        Reset();
    }

    public override void Update(double deltaTime) { }

    //TODO look for icue.exe and startup enabled
    public override List<IModuleActivationRequirement>? ActivationRequirements { get; }

    private void Reset()
    {
        DataModel.ConnectedGame = string.Empty;
        DataModel.IsGameConnected = false;
        DataModel.GameStates.Clear();
    }
}