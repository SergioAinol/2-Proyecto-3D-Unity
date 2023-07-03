using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirChan : MonoBehaviour
{
    public Transform target; // Referencia al transform del jugador
    public float followDistance = 2.0f; // Margen de distancia para seguir al jugador

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Calcular la dirección hacia el jugador
        Vector3 direction = target.position - transform.position;
        direction.y = 0; // Ignorar la diferencia de altura

        // Si la distancia es mayor que el margen, moverse hacia el jugador
        if (direction.magnitude > followDistance)
        {
            transform.position += direction.normalized * Time.deltaTime;
        }

        // Rotar para mirar hacia el jugador
        if (direction.magnitude > 0)
        {
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 5.0f);
        }
    }
}
