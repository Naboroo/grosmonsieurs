using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballProjectile : MonoBehaviour
{
    [HideInInspector]
    public Vector3 target;
    //[HideInInspector]
    public float range;
    //[HideInInspector]
    public float damage;
    public float moveSpeed;
    private Vector3 startPosition;
    void Start(){
        startPosition = transform.position;
    }
    void FixedUpdate()
    {
        if (target != null)
        {
            float distanceToStart = Mathf.Abs(Vector3.Distance(transform.position, startPosition));

            if (distanceToStart < range && transform.position!=target)
            {
                Vector3 moveDirection = (target - transform.position).normalized;
                transform.position = Vector3.MoveTowards(transform.position, target, moveSpeed * Time.fixedDeltaTime);
            }
            else
            {
                Destroy(gameObject);
            }   
        }
    }
    void OnTriggerEnter(Collider collider){
        if(collider.gameObject.GetComponent<AgentController>()){
            AgentController agentController=collider.gameObject.GetComponent<AgentController>();
            agentController.ApplyDamage(damage);
            Debug.Log("applied damage to " + collider.gameObject.name);
            GameObject.Destroy(gameObject);
        }
    }
}
