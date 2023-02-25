using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AgentStats
{
    public float health;
    public float armor;
    public float damage;
    public float attackSpeed;
    public float cdr;
    public float moveSpeed;
    public float angularSpeed;
    public float goldReward;
    public float xpReward;
    public float mana;
    public AgentStats (AgentStats original){
        health=original.health;
        armor=original.armor;
        damage=original.damage;
        attackSpeed=original.attackSpeed;
        cdr=original.cdr;
        moveSpeed=original.moveSpeed;
        angularSpeed=original.angularSpeed;
        goldReward=original.goldReward;
        xpReward=original.goldReward;
        mana=original.mana;
    }
}
