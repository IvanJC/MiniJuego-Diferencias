using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuestraSuPar : MonoBehaviour
{
    //Muestra el par, se puede simplificar o hacer un arreglo con todos en 1 solo script dentro del controlador
    public GameObject GOMostrar;

    private void OnMouseDown()
    {
        GOMostrar.SetActive(true);
    }
}
