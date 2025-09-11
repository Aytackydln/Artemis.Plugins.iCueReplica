using System;
using System.Collections.Generic;
using Artemis.Core;
using Artemis.Core.Modules;
using JetBrains.Annotations;

namespace Artemis.Plugins.iCueReplica.DataModels;

[PublicAPI]
public class IcueGameStateData : DataModel
{
    public bool IsGameConnected { get; set; }
    public string ConnectedGame { get; set; } = string.Empty;
    public HashSet<string> GameStates { get; set; } = [];
    public HashSet<string> GameEvents { get; set; } = [];
    
    public DataModelEvent<IcueGameStateEventArgs> GameEventTriggered { get; set; } = new();
    
    public void OnGameEventTriggered(string eventName)
    {
        GameEventTriggered.Trigger(new IcueGameStateEventArgs(eventName));
    }
}

[PublicAPI]
public class IcueGameStateEventArgs(string stateName) : DataModelEventArgs
{
    public string StateName { get; } = stateName;
}