using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victoria : MonoBehaviour
{
    [SerializeField] GameObject panelVictoria;
    [SerializeField] AudioBackground audioBackground;
    public GameObject botonSkip;
    AudioSource audioSource;

    public int contadorFueguitos = 15;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
   
    public void Ganar()
    {
        if (contadorFueguitos == 0)
        {
            panelVictoria.SetActive(true);
            botonSkip.SetActive(true);
            audioSource.volume = 0;
            audioBackground.CambioSonido();
        }
    }    
}

