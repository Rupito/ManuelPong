using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugador2 : MonoBehaviour
{
    float velocidad;


    void Start()
    {

        velocidad = 6.0f; // velocidad del jugador
    }

  

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0f, velocidad * Time.deltaTime, 0f);  //detectar una tecla "flechita arriba" para que se mueve para arriba
        }



        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= new Vector3(0f, velocidad * Time.deltaTime, 0f);  //detectar una tecla "flechita abajo" para que se mueve para abajo
        }
    }
}
