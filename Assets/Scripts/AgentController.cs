using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentController : MonoBehaviour
{
    public AgentStats baseStats;
    [HideInInspector]
    public AgentStats agentStatsInstance;
    void Awake(){
        InstantiateAgentStats();
    }
    void InstantiateAgentStats()
    {
        agentStatsInstance = new AgentStats(baseStats);
    }
}
