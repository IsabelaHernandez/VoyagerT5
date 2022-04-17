using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Planet_selector : MonoBehaviour
{
    public Button[] nivelBTN;
    void Start()
    {
        int nivel = PlayerPrefs.GetInt("nivel", 2);

        for (int i = 0; i < nivelBTN.Length; i++)
        {
            if (i + 2 > nivel)
                nivelBTN[i].interactable = false;
        }
    }

   
}
