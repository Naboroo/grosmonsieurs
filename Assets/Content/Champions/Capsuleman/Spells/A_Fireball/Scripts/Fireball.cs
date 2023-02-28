using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : Spell
{
    public float range=1;
    public float projectileSpeed=1;
    public GameObject projectilePrefab;
    public KeyCode spellCommand;
    void Update(){
        SpellInputSystem(spellCommand);
    }

    public override void SpellEffect()
    {
        base.SpellEffect();
        //Add spell logic here
        FireballProjectile fireballProjectile = GameObject.Instantiate(projectilePrefab, transform.position, Quaternion.identity).GetComponent<FireballProjectile>();
        if(CameraManager.cameraInstance.GetWorldPoint(Input.mousePosition, out Vector3 clickPos)){
            fireballProjectile.target=new Vector3(clickPos.x, transform.position.y, clickPos.z);
        }
        fireballProjectile.damage = this.spellStatsInstance.damage;
        fireballProjectile.range = range;
        fireballProjectile.moveSpeed = projectileSpeed;
    }
    //Use the following functions by overriding them in the spell sub-class (public override void)
    public void SpellInputSystem(KeyCode keyCode){
        if (Input.GetKeyDown(keyCode)){
            SpellEffect();
        }
    }
}
