using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Hola_Mundo : MonoBehaviour
{
    int x;


    // Start is called before the first frame update
    void Start()
    {
        print("Hola Mundo");
        Debug.Log("Algo salio mal");
        Debug.LogWarning("Algo salio medianamente mal");
        Debug.LogError("Tienes suerte de que tu PC no haya explotado xd");
        x = 1;


    }

    // Update is called once per frame
    void Update()
    {
        //x = x + 1;
        //Debug.Log(x);

        Debug.Log("Hola desde Update");

    }
    private void FixedUpdate()
    {

        Debug.LogWarning("Hola desde Fixed Update cada 50 frames");
    }
    private void LateUpdate()
    {
        Debug.Log("Hola desde late update");

    }
    private void OnEnable()
    {
        Debug.LogWarning("El objeto ha sido habilitado");
    }
    private void OnDisable()
    {
        Debug.LogWarning("El objeto ha sido inhabilitado");
    }
}

