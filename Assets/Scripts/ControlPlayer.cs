using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
   
    float speed = 3.0f;
    float runSpeedMultiplier = 2.0f; // Multiplicador de velocidad al correr
    float angle = 1.0f;
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        bool isRunning = Input.GetKey(KeyCode.LeftShift);// Verificar si se está presionando la tecla de correr

        transform.Rotate(0, horizontal * angle, 0, Space.Self);

        Vector3 moveDirection = new Vector3(0, 0, vertical);
        moveDirection = transform.rotation * moveDirection;
        transform.position += (moveDirection * speed * Time.deltaTime);

        // Activar la animación de caminar si el jugador está caminando
        if (vertical != 0 && !isRunning)
        {
            //animator.SetTrigger("Walk");
            animator.SetBool("IsWalking", true);
        }
        else
        {
            //animator.ResetTrigger("Walk");
            animator.SetBool("IsWalking", false);
        }

        // Activar la animación de correr si el jugador está corriendo
        if (isRunning)
        {
            //animator.SetTrigger("Run");
            animator.SetBool("IsRunning", true);
            // Verificar si se está corriendo y ajustar la velocidad en consecuencia
            float currentSpeed = isRunning ? speed * runSpeedMultiplier : speed;
            transform.position += (moveDirection * currentSpeed * Time.deltaTime);
        }
        else
        {
            // Reiniciar el parámetro de la animación de correr
            // animator.ResetTrigger("Run");
            animator.SetBool("IsRunning", false);
        }
            
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemigo")
        {
            animator.SetTrigger("Die");
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
           animator.SetTrigger("Die");
        }
        
    }
}
