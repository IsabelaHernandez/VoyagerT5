using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victoria : MonoBehaviour
{
    [SerializeField] GameObject panelVictoria;
    [SerializeField] AudioBackground audioBackground;
    AudioSource audioSource;

    public int contadorFueguitos = 17;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Ganar()
    {
        if (contadorFueguitos == 0)
        {
            panelVictoria.SetActive(true);
            audioSource.volume = 0;
            audioBackground.CambioSonido();
        }
    }    
}

