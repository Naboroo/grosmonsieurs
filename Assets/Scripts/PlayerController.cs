using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    [Range(0,1)]
    public float cameraMoveTreshold;
    public float cameraSpeed;
    private Vector3 destinationPos;
    private NavMeshAgent myAgent;
    void Start(){
        myAgent=GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        if(Mathf.Abs(Input.mousePosition.x - Screen.width/2) >= Screen.width/2*cameraMoveTreshold || Mathf.Abs(Input.mousePosition.y - Screen.height / 2) >= Screen.height / 2 * cameraMoveTreshold)
        {
            CameraManager.instance.transform.position += new Vector3(Input.mousePosition.x - Screen.width/2, 0, Input.mousePosition.y - Screen.height / 2).normalized * cameraSpeed * Time.deltaTime;
        }

        if(Input.GetMouseButton(1)){
            if (CameraManager.instance.GetWorldPoint(Input.mousePosition, out Vector3 clickPos)) {
                myAgent.SetDestination(clickPos);
            } else if (CameraManager.instance.GetObject(Input.mousePosition)){
                //if gameobject.component<creep>() => oui attaque le creep
            } 
        }
    }
}
