using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioCamara : MonoBehaviour
{
    public GameObject[] listaCamaras;

    void Start()
    {
        listaCamaras[0].gameObject.SetActive(true);
        listaCamaras[1].gameObject.SetActive(false);
        listaCamaras[2].gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            listaCamaras[0].gameObject.SetActive(true);
            listaCamaras[1].gameObject.SetActive(false);
            listaCamaras[2].gameObject.SetActive(false);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            listaCamaras[0].gameObject.SetActive(false);
            listaCamaras[1].gameObject.SetActive(true);
            listaCamaras[2].gameObject.SetActive(false);
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            listaCamaras[0].gameObject.SetActive(false);
            listaCamaras[1].gameObject.SetActive(false);
            listaCamaras[2].gameObject.SetActive(true);
        }
    }
}
