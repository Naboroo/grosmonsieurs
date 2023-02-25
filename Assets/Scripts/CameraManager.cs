using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public static CameraManager cameraInstance;
    private Camera _cam;
    public GameObject playerObject;
    //Camera parameters
    [Range(0, 1)]
    public float cameraMoveTreshold;
    public float cameraSpeed;
    public Vector3 cameraOffset;
    void Awake()
    {
        cameraInstance = this;
        _cam = GetComponent<Camera>();
        
        //Camera moves to center
        cameraInstance.transform.position = new Vector3(playerObject.transform.position.x + cameraOffset.x, playerObject.transform.position.y + cameraOffset.y, playerObject.transform.position.z + cameraOffset.z);

    }
    void Update()
    {
        //Camera movement: camera moves when cursor on border + camera goes back to initial pos
        if (Mathf.Abs(Input.mousePosition.x - Screen.width / 2) >= Screen.width / 2 * cameraMoveTreshold || Mathf.Abs(Input.mousePosition.y - Screen.height / 2) >= Screen.height / 2 * cameraMoveTreshold)
        {
            cameraInstance.transform.position += new Vector3(Input.mousePosition.x - Screen.width / 2, 0, Input.mousePosition.y - Screen.height / 2).normalized * cameraSpeed * Time.deltaTime;
        }
        //Space to move camera back to base position
        if (Input.GetKey(KeyCode.Space))
        {
            cameraInstance.transform.position = new Vector3(playerObject.transform.position.x + cameraOffset.x, playerObject.transform.position.y + cameraOffset.y, playerObject.transform.position.z + cameraOffset.z);
        }
    }

    public bool GetWorldPoint(Vector2 pos, out Vector3 worldPoint, int layerMask = 1)
    {
        Ray ray = ray = _cam.ScreenPointToRay(pos);
        worldPoint = Vector3.zero;
        if (Physics.Raycast(ray, out RaycastHit hitInfo, 1000000f, layerMask))
        {
            worldPoint = hitInfo.point;
            return true;
        }
        return false;
    }
    public GameObject GetObject(Vector2 pos, int layerMask = 1)
    {
        Ray ray = ray = _cam.ScreenPointToRay(pos);
        if (Physics.Raycast(ray, out RaycastHit hitInfo, 1000000f, layerMask))
        {
            return hitInfo.transform.gameObject;
        }
        return null;
    }
}
