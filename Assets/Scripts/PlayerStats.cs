using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : AgentStats
{
    public AgentStatsScriptableObject agentStats;
    public float health;
    public float moveSpeed;
    public float baseDamage;
    public float attackSpeed;
    void Awake()
    {
        health = agentStats.health;
        moveSpeed = agentStats.moveSpeed;
        baseDamage = agentStats.baseDamage;
        attackSpeed = agentStats.baseDamage;
    }
}
