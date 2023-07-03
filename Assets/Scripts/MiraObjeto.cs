using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiraObjeto : MonoBehaviour
{
    public Transform target;

    void LateUpdate()
    {
        if (target == null)
        {
        transform.position = target.position;
        transform.LookAt( target.position );
        }
        
    }
}
