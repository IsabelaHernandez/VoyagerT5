using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class panelText : MonoBehaviour
{
    public GameObject Panel;
    [SerializeField] private AudioClip compressClip;
    [SerializeField] private AudioSource source;

    public void OpenPanel()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;

            Panel.SetActive(!isActive);

            source.PlayOneShot(compressClip);
        }
    }
}
