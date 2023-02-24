using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private NavMeshAgent navMeshAgent;
    [SerializeField]
    private PlayerStats _playerStats;
    void Awake()
    {
        navMeshAgent.speed = _playerStats.moveSpeed;
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
