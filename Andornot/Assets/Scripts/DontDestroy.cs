using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    // Start is called before the first frame update

    public static DontDestroy reproducir;

    private void Awake()
    {
        if (reproducir == null)
        {
            reproducir = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (reproducir != this)
            Destroy(gameObject);
        
    }

  
}
