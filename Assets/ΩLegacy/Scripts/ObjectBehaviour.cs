using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBehaviour : MonoBehaviour
{
    public virtual void OnKey(KeyCode kc)
    {
        Debug.Log("test");
    }
}
