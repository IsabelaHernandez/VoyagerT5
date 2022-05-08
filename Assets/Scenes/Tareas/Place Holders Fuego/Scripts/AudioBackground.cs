using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBackground : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField] AudioClip victory;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void CambioSonido()
    {
        audioSource.Stop();
        audioSource.clip = victory;        
        audioSource.Play();
    }
}
