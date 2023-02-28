using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : Spell
{
    public KeyCode spellCommand;
    void Update(){
        SpellInputSystem(spellCommand);
    }

    public override void SpellEffect()
    {
        base.SpellEffect();
        //Add spell logic here
        Debug.Log("Spell " + this.ToString() +" launched with command: "+ spellCommand);
    }
    //Use the following functions by overriding them in the spell sub-class (public override void)
    public void SpellInputSystem(KeyCode keyCode){
        if (Input.GetKeyDown(keyCode)){
            SpellEffect();
        }
    }
}
