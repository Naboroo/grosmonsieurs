using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMousePosition : MonoBehaviour
{
    public Vector3 OnKey(KeyCode kc){
        Ray ray;
        RaycastHit hitInfo;
        Vector3 hitPos=Vector3.zero;
        if (Input.GetKeyDown(kc)){
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hitInfo)){
                hitPos=hitInfo.point;
                Debug.Log(hitInfo.point);
            }
        }
        return hitPos;
    }
}
