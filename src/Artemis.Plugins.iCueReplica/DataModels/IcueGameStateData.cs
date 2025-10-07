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
    public List<string> GameStates { get; set; } = [];
    public List<string> GameEvents { get; set; } = [];
    
    public DataModelEvent<IcueGameStateEventArgs> GameEventTriggered { get; set; } = new();
    
    public void OnGameEventTriggered(string eventName)
    {
        GameEventTriggered.Trigger(new IcueGameStateEventArgs(eventName));
        GameEventTriggered.Reset();
    }
}

[PublicAPI]
public class IcueGameStateEventArgs(string stateName) : DataModelEventArgs
{
    public string StateName { get; } = stateName;
}