using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform target;
    public float distance = 5f;
    public float velocidadGiro = 10f;

    void Update()
    {

        //transform.LookAt( target.position );

        //transform.position = new Vector3( target.position.x, transform.position.y, transform.position.z + distance - (transform.position.z - target.position.z ) );

        transform.RotateAround(target.position, Vector3.up, velocidadGiro * Time.deltaTime);
    }
}
