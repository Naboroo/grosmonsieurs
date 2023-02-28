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
    void Start()
    {
        //Temporary way of giving speed stats to NavMeshAgent => problem: changing speed (i.e. with debuff) can't update live this way
        navMeshAgent.speed = playerController.agentStatsInstance.moveSpeed;
        navMeshAgent.angularSpeed = playerController.agentStatsInstance.angularSpeed;
    }
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            if (CameraManager.cameraInstance.GetObject(Input.mousePosition).transform.gameObject.GetComponent<AgentController>())
            {
                Debug.Log("Name:" + CameraManager.cameraInstance.GetObject(Input.mousePosition).transform.name);
            }
            else if (CameraManager.cameraInstance.GetWorldPoint(Input.mousePosition, out Vector3 clickPos))
            {
                navMeshAgent.SetDestination(clickPos);
            }
        }
    }
}
