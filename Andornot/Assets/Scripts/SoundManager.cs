using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{

   public GameObject objeto;
    private AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = objeto.GetComponent<AudioSource>();

    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

           
            
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            
            if (hit.collider != null )
            {
                audio.Play();
            }
        }
    }
}
