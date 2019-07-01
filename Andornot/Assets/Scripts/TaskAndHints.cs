using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskAndHints : MonoBehaviour
{

    public Text[] textes;
    public Image[] images;
    private int currentPage;
    private int numeroMax, numeroMin;
    public Button paginaDelante;
    public Button paginaDetras;


    void Start()
    {
        textes[0].gameObject.SetActive(true);
        images[0].gameObject.SetActive(true);
        numeroMax = textes.Length - 1;
        numeroMin = 0;
        paginaDetras.gameObject.SetActive(false);
        currentPage = 0;
        if(textes.Length == 1)
            paginaDelante.gameObject.SetActive(false);
        else
            numeroMax = textes.Length - 1;
    }

    public void SiguientePagina()
    {
        if (currentPage == numeroMin)
        {
            paginaDetras.gameObject.SetActive(true);

        }
        if (currentPage < numeroMax)
        {
            textes[currentPage].gameObject.SetActive(false);
            images[currentPage].gameObject.SetActive(false);
            currentPage++;
            textes[currentPage].gameObject.SetActive(true);
            images[currentPage].gameObject.SetActive(true);
            Debug.Log(currentPage);
            
        }
        if (currentPage == numeroMax)
            paginaDelante.gameObject.SetActive(false);
        
    }

    public void AnteriorPagina()
    {
        if (currentPage == numeroMax)
            paginaDelante.gameObject.SetActive(true);

        if (currentPage > numeroMin)
        {
            textes[currentPage].gameObject.SetActive(false);
            images[currentPage].gameObject.SetActive(false);
            currentPage--;
            textes[currentPage].gameObject.SetActive(true);
            images[currentPage].gameObject.SetActive(true);
            Debug.Log("se ha pulsao patras");
        }
        if (currentPage == numeroMin)
        {
            paginaDetras.gameObject.SetActive(false);
        }
            


    }
    
    
}
