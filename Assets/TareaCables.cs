using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TareaCables : MonoBehaviour
{
    public int conexionesActuales;
    public GameObject caja, exito;

    [SerializeField] GameObject tareaCables;
    [SerializeField] List<AudioClip> audios;
    [SerializeField] AudioSource background;

    public void ComprobarVictoria()
    {
        background = FindObjectOfType<AudioSource>();
        background.clip = audios[0];

        if (conexionesActuales == 4)
        {
            background.clip = audios[1];
            background.PlayOneShot(audios[1]);

            Destroy(caja, 0.99f);
            Destroy(tareaCables, 1f);

            Invoke(nameof(Exito), 1f);   
        }
      
    }
    
    public void Exito() { exito.SetActive(true); }


}