using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public SpellStats baseStats;
    [HideInInspector]
    public SpellStats spellStatsInstance;
    void Awake(){
        InstantiateSpellStats();
    }
    void InstantiateSpellStats()
    {
        spellStatsInstance = new SpellStats(baseStats);
    }
    public virtual void SpellEffect(){}
}
