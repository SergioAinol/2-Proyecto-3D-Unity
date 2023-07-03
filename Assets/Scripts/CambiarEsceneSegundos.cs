using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CambiarEsceneSegundos : MonoBehaviour
{
    public string sceneName;  // Nombre de la escena a la que se cambiará

    private float timer = 0f;
    private float changeSceneTime = 30f;  // Tiempo en segundos para cambiar de escena

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= changeSceneTime)
        {
            ChangeScene();
        }

    }
    private void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);
    }

}
