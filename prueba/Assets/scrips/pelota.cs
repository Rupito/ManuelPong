using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // para que reconozca los comandos de puntaje de texto

public class pelota : MonoBehaviour   
{
    public TextMeshProUGUI ContarPuntos;
    public TextMeshProUGUI ContarPuntos2;     //puntaje de texto
    int contar1;
    int contar2;

    float velocidadInicialX;
    float velocidadInicialY;           // reiniciar la pelota a su velocidad inicial cuando hacen punto

    float velocidadx;
    float velocidady;                  //velocidad inicial de la pelota

    int suma1, suma2;                  // puntaje que se muestra desde la consola cuando un player hace punto

    public GameObject jugador1;
    public GameObject jugador2;        // reiniciar los jugadores a su posicion inicial cuando hacen punto


    void Start()
    {
        contar1 = 0;
        contar2 = 0;                                  //puntaje de texto
        ContarPuntos.text = contar1.ToString();
        ContarPuntos2.text = contar2.ToString();

        velocidadx = 4.0f;
        velocidady = 4.0f;                           //velocidad inicial de la pelota

        velocidadInicialX = velocidadx;
        velocidadInicialY = velocidady;              // reiniciar la pelota a su velocidad inicial cuando hacen punto
    }


    void Update()
    {
        transform.position += new Vector3(velocidadx * Time.deltaTime, velocidady * Time.deltaTime, 0f);   //Direccion de la pelota
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "cubo")
        {
            velocidady *= -1.0f;                        // cambiar de direccion cuando colisiona con el techo y el piso
        }



        if (collision.gameObject.tag == "Player")
        {
            if (velocidadx < 0)
            {
                velocidadx -= 0.5f;
            }
            else                                         // ir aumentando la velocidad
            {
                velocidadx += 0.5f;
            }

            velocidadx *= -1.0f;
        }



        if (collision.gameObject.tag == "pared")
        {
            jugador1.transform.position = new Vector3(-6.66f, 0f, 0f);  // reiniciar los jugadores a su posocion inicial cuando hacen punto
            jugador2.transform.position = new Vector3(6.66f, 0f, 0f);
        }


        if (collision.gameObject.name == "pared Derecha")
        {
            contar2 += 1;
            ContarPuntos2.text = contar2.ToString();     //puntaje de texto

            suma1 += 1;
            Debug.Log("jugador 1 lleva " + suma1);       //puntaje que se muestra desde la consola cuando un player hace punto

            transform.position = new Vector3(0f, 0f, 0f);  //reiniciar la pelota a su posicion inicial cuando hacen punto

            velocidadx = velocidadInicialX;
            velocidady = velocidadInicialY;              // reiniciar la pelota a su velocidad inicial cuando hacen punto
        }



        if (collision.gameObject.name == "pared 1")
        {
            contar1 += 1;
            ContarPuntos.text = contar1.ToString();      //puntaje de texto

            suma2 += 1;
            Debug.Log("jugador 2 lleva " + suma2);       //puntaje que se muestra desde la consola cuando un player hace punto

            transform.position = new Vector3(0f, 0f, 0f);  //reiniciar la pelota a su posicion inicial cuando hacen punto

            velocidadx = velocidadInicialX;
            velocidady = velocidadInicialY;              // reiniciar la pelota a su velocidad inicial cuando hacen punto
        }
    }

}
