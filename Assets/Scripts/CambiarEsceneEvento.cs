using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEsceneEvento : MonoBehaviour
{
    public int numEscena;  // Nombre de la escena a la que se cambiará

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            SceneManager.LoadScene(numEscena);
        }
    }
}
