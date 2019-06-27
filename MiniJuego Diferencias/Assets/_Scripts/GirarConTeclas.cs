using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirarConTeclas : MonoBehaviour
{
    //Mueve el padre de los objetos
    //Se puede agregar un rigidbody para que se muevan un poco o caigan al piso

    //Se puede usar una velocidad fija o una public para ir viendo como queda
    void FixedUpdate()
    {
        //Flecha Izquierda
        if (Input.GetKey(KeyCode.LeftArrow)) {
            this.gameObject.transform.Rotate(0,10,0);
        }
        //Flecha Derecha
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.gameObject.transform.Rotate(0, -10, 0);
        }
    }
}
