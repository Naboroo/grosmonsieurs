using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballProjectile : MonoBehaviour
{
    [HideInInspector]
    public Vector3 target;
    [HideInInspector]
    public float range;
    [HideInInspector]
    public float damage;
    public float moveSpeed;
    void FixedUpdate()
    {
        if (target != null)
        {
            float distanceToTarget = Vector3.Distance(transform.position, target);

            if (distanceToTarget > range)
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
}
