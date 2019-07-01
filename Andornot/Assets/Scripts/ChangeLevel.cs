using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{

    public int nivel;
    public void playFree()
    {
        SceneManager.LoadScene(nivel);
    }
}
