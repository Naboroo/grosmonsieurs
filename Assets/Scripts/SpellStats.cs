using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class SpellStats
{
    public float cooldown;
    public float manaCost;
    public float damage;
    public float heal;
    public SpellStats (SpellStats original){
        cooldown=original.cooldown;
        manaCost=original.manaCost;
        damage=original.damage;
        heal=original.heal;
    }
}
