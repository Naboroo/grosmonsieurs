using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    //Camera parameters
    [Range(0,1)]
    public float cameraMoveTreshold;
    public float cameraSpeed;
    public Vector3 cameraOffset;
    private NavMeshAgent myAgent;
    void Start(){
        myAgent=GetComponent<NavMeshAgent>();
        CameraManager.instance.transform.position = new Vector3(transform.position.x+cameraOffset.x, transform.position.y+cameraOffset.y, transform.position.z+cameraOffset.z);
    }
    void Update()
    {
        //Camera movement: camera moves when cursor on border + camera goes back to initial pos
        if(Mathf.Abs(Input.mousePosition.x - Screen.width/2) >= Screen.width/2*cameraMoveTreshold || Mathf.Abs(Input.mousePosition.y - Screen.height / 2) >= Screen.height / 2 * cameraMoveTreshold)
        {
            CameraManager.instance.transform.position += new Vector3(Input.mousePosition.x - Screen.width/2, 0, Input.mousePosition.y - Screen.height / 2).normalized * cameraSpeed * Time.deltaTime;
        }

        //Space to move camera back to base position
        if (Input.GetKey(KeyCode.Space)){
            CameraManager.instance.transform.position = new Vector3(transform.position.x+cameraOffset.x, transform.position.y+cameraOffset.y, transform.position.z+cameraOffset.z);
        }

        if(Input.GetMouseButton(1)){
            if (CameraManager.instance.GetObject(Input.mousePosition).transform.gameObject.GetComponent<ObjectBehaviour>()){
                Debug.Log("Name:" + CameraManager.instance.GetObject(Input.mousePosition).transform.name + "| Type:" + CameraManager.instance.GetObject(Input.mousePosition).GetComponent<ObjectBehaviour>().ToString());
            } else {
                if (CameraManager.instance.GetWorldPoint(Input.mousePosition, out Vector3 clickPos)) {
                    myAgent.SetDestination(clickPos);
                } 
            }
        }
    }
}
