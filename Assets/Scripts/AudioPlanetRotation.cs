using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlanetRotation : MonoBehaviour
{
    public AudioSource Audio;
    public float rate = 0.01f;
    public bool moviendose;

    void Start()
    {
        Audio.volume = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a") || Input.GetKeyDown("d"))
        {
            moviendose = true;
            StartCoroutine(ActivateVolume());
        }
        if (Input.GetKeyUp("a") || Input.GetKeyUp("d"))
        {
            moviendose = false;
            StartCoroutine(ActivateVolume());

        }
    }
    IEnumerator ActivateVolume()
    {
        if (moviendose)
        {
            float cantidad = Audio.volume;
            while (cantidad < 0.8 & moviendose)
            {
                cantidad += rate;
                Audio.volume = cantidad;
                yield return new WaitForSeconds(0.1f);
            }
        }
        else
        {
            float cantidad = Audio.volume;
            while (cantidad > 0 & !moviendose)
            {
                cantidad -= rate;
                Audio.volume = cantidad;
                yield return new WaitForSeconds(0.1f);
                if (cantidad <= 0 + rate)
                {
                    cantidad = 0;                   
                }
            }
        }
    }
}
