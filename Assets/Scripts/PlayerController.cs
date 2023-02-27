using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : AgentController
{
    public PlayerStats basePlayerStats;
    //[HideInInspector]
    public PlayerStats playerStatsInstance;
    public List<SpellController> spells = new List<SpellController>();
    protected override void Awake()
    {
        base.Awake();
        InstantiatePlayerStats();
        //Instantiate Spells as children of the Player
        for (int i = 0; i < spells.Count; i++)
        {
            SpellController tempSpells = Instantiate(spells[i], transform.position, Quaternion.identity);
            tempSpells.transform.parent = transform;
        }
    }
    void InstantiatePlayerStats()
    {
        playerStatsInstance = new PlayerStats(basePlayerStats);
    }
}
