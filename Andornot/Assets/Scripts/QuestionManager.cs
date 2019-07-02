using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour
{

    public bool[] respuestas;
    private bool[] respuestasUsuario;

    public Image correcto;
    public Image incorecto;
    public GameObject cambioDeNivel;
    private bool finished;


    void Start()
    {
        finished = false;
        respuestasUsuario = new bool[4];
        for(int i = 0; i < respuestas.Length; i++)
        {
            respuestasUsuario[i] = false;            
        }
            
    }

    public void RespuestaSeleccionada(int respuestaSeleccionada)
    {
        if (finished == false)
        {
            if (respuestasUsuario[respuestaSeleccionada] == false)
                respuestasUsuario[respuestaSeleccionada] = true;
            else
                respuestasUsuario[respuestaSeleccionada] = false;
        }
    }

    public void ComprobarCircuito()
    {
        bool comprobar = true; 
        for(int i = 0; i<respuestas.Length; i ++)
        {
            if (respuestas[i] != respuestasUsuario[i])
            {
                comprobar = false;
            }               
           
        }

        if (comprobar == true && finished == false)
        {
            finished = true;
            incorecto.gameObject.SetActive(false);
            correcto.gameObject.SetActive(true);
            cambioDeNivel.SetActive(true);
        }
        else if(finished == false)
            incorecto.gameObject.SetActive(true);
            
    }

}
