using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public static CameraManager instance;
    private Camera cam;
    void Awake(){
        instance=this;
        cam=GetComponent<Camera>();
    }
    public bool GetWorldPoint(Vector2 pos, out Vector3 worldPoint, int layerMask=1){
        Ray ray=ray = cam.ScreenPointToRay(pos);
        worldPoint=Vector3.zero;
        if(Physics.Raycast(ray, out RaycastHit hitInfo, 1000000f, layerMask)){
            worldPoint = hitInfo.point;
            return true;
        }
        return false;
    }
    public GameObject GetObject(Vector2 pos, int layerMask=1){
        Ray ray=ray = cam.ScreenPointToRay(pos);
        if(Physics.Raycast(ray, out RaycastHit hitInfo, 1000000f, layerMask)){
            return hitInfo.transform.gameObject;
        }
        return null;        
    }
}
