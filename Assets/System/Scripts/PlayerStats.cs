using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerStats
{
    public float tenacity;
    public PlayerStats (PlayerStats original){
        tenacity=original.tenacity;
    }
}
