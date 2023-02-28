using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : AgentController
{
    public PlayerStats basePlayerStats;
    //[HideInInspector]
    public PlayerStats playerStatsInstance;
    protected override void Awake()
    {
        base.Awake();
        InstantiatePlayerStats();
    }
    void InstantiatePlayerStats()
    {
        playerStatsInstance = new PlayerStats(basePlayerStats);
    }
    
}
