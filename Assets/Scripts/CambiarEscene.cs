using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscene : MonoBehaviour
{
    public bool pasarEscena;
    public int indiceEscena;
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SwitchScene", 20f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            CambiarEscena(indiceEscena);
        }
        if(pasarEscena)
        {
            CambiarEscena(indiceEscena);
        }
    }
    public void CambiarEscena(int indice)
    {
        SceneManager.LoadScene(indice);
    }
    void SwitchScene()
    {
        SceneManager.LoadScene(sceneName); // Cargar la escena especificada
    }
}
