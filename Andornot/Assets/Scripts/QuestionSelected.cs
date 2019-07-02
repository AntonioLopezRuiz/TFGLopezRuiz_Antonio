using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionSelected : MonoBehaviour
{
    public GameObject image;
    private bool active;
    private GameObject parent;

    
    // Start is called before the first frame update
    void Start()
    {

        active = false;
    }

    public void ButtonSelected()
    {
        if(active == false)
        {
            image.SetActive(true);
            active = true;
        }
        else
        {
            image.SetActive(false);
            active = false;
        }



    }
}
