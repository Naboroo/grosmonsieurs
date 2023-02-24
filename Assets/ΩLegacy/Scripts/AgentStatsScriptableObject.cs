using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "AgentStats/New Agent Stats", order = 1)]
public class AgentStatsScriptableObject : ScriptableObject
{

    public string agentName;
    public float health;
    public float moveSpeed;

    public float baseDamage;
    public float attackSpeed;
}
