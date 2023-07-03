using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuegoFinalizado : MonoBehaviour
{
    public GameObject canvasPrimera;
    public GameObject canvasSegunda;
    public GameObject canvasTercera;

    // Start is called before the first frame update
    void Start()
    {
        // Ocultar el Canvas al inicio del juego
        canvasPrimera.SetActive(false);
        canvasSegunda.SetActive(false);
        canvasTercera.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canvasPrimera.SetActive(true);
            canvasSegunda.SetActive(true);
            canvasTercera.SetActive(true);
        }
    }

}
