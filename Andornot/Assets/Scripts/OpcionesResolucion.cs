using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpcionesResolucion : MonoBehaviour
{


    public GameObject objetoConAudio;
    public GameObject objetoConAudio2;
    private AudioSource audio;



    public void Awake()
    {
        audio = objetoConAudio.GetComponent<AudioSource>();


    }

    public void SetVolume(float volumen)
    {
        Debug.Log("Se ha llegao: " + audio.volume);
        audio.volume = volumen;

    }


   


    public void ChangeResolution(int x, int y)
    {
        Screen.SetResolution(x, y, true);
        Debug.Log(Screen.currentResolution);
    }

    public void ResolucionUno()
    {
        ChangeResolution(640, 350);        
    }

    public void ResolucionDos()
    {     
        ChangeResolution(720, 360);      
    }

    public void ResolucionTres()
    {
        ChangeResolution(1024, 768);
    }

    public void ResolucionCuatro()
    {
        ChangeResolution(1280, 768);
    }

    public void ResolucionCinco()
    {
        ChangeResolution(1366, 760);

    }

    public void ResolucionSeis()
    {
        ChangeResolution(1920, 1080);
    }
}
