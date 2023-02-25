using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentController : MonoBehaviour
{
    public AgentStats baseStats;
    [HideInInspector]
    public AgentStats agentStatsInstance;
    void Awake(){
        InstantiateStats();
    }
    void InstantiateStats()
    {
        agentStatsInstance = new AgentStats(baseStats);
    }
}
