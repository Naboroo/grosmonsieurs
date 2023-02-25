using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellController : MonoBehaviour
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
    //Use the following functions by overriding them in the spell sub-class (public override void)
    public virtual void SpellInputSystem(KeyCode keyCode){
        if (Input.GetKeyDown(keyCode)){
            SpellEffect();
        }
    }
    public virtual void SpellEffect(){}
}
