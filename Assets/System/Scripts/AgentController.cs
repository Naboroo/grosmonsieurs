using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentController : MonoBehaviour
{
    public AgentStats baseAgentStats;
    //[HideInInspector]
    public AgentStats agentStatsInstance;
    protected virtual void Awake(){
        InstantiateAgentStats();
    }
    void InstantiateAgentStats()
    {
        agentStatsInstance = new AgentStats(baseAgentStats);
    }
}
