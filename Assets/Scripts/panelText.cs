using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Audio;

public class panelText : MonoBehaviour
{
    public GameObject Panel;
    [SerializeField] private AudioClip compressClip;
    [SerializeField] private AudioSource source;

    public GameObject flechaTuto;

    public AudioMixer mixer;
   


    public void OpenPanel()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;

            Panel.SetActive(!isActive);
            Destroy(flechaTuto);
            source.PlayOneShot(compressClip);
        }
    }
    
}
