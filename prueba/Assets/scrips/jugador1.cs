using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugador1 : MonoBehaviour
{
    float velocidad;


    void Start()
    {
        velocidad = 6.0f; //velocidad del jugador
    }



    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0f, velocidad * Time.deltaTime, 0f);  //detectar una tecla "W" para que se mueve para arriba
        }



        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0f, velocidad * Time.deltaTime, 0f);  //detectar una tecla "S" para que se mueve para abajo
        }
    }

}
