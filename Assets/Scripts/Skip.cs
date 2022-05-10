using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Skip : MonoBehaviour
{
    public int numeroEscena;
    void Update()
    {
        if(numeroEscena == 4 || numeroEscena == 6 || numeroEscena == 9 || numeroEscena == 12 || numeroEscena == 15 || numeroEscena == 18)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(numeroEscena);
            }
        }
       
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(numeroEscena);
    }
}
