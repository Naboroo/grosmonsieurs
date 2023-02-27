using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : SpellController
{
    public KeyCode spellCommand;
    void Update(){
        SpellInputSystem(spellCommand);
    }

    public override void SpellEffect()
    {
        base.SpellEffect();
        //Add spell logic here
    }
}
