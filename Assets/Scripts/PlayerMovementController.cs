using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField]
    private NavMeshAgent navMeshAgent;
    [SerializeField]
    private PlayerController playerController;
    void Awake()
    {
        navMeshAgent.speed = playerController.agentStatsInstance.moveSpeed;
    }
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            if (CameraManager.instance.GetObject(Input.mousePosition).transform.gameObject.GetComponent<ObjectBehaviour>())
            {
                Debug.Log("Name:" + CameraManager.instance.GetObject(Input.mousePosition).transform.name + "| Type:" + CameraManager.instance.GetObject(Input.mousePosition).GetComponent<ObjectBehaviour>().ToString());
            }
            else if (CameraManager.instance.GetWorldPoint(Input.mousePosition, out Vector3 clickPos))
            {
                navMeshAgent.SetDestination(clickPos);
            }
        }
    }
}
