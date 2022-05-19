using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Audio;

public class panelText : MonoBehaviour
{
    public GameObject Panel;
    public GameObject[] restoPaneles;
    [SerializeField] private AudioClip compressClip;
    [SerializeField] private AudioSource source;

    public GameObject flechaTuto;

    public AudioMixer mixer;
   


    public void OpenPanel()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;
            restoPaneles[0].SetActive(false);
            restoPaneles[1].SetActive(false);
            restoPaneles[2].SetActive(false);

            Panel.SetActive(!isActive);
            Destroy(flechaTuto);
            source.PlayOneShot(compressClip);
        }
    }
    
}
