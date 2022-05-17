using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Audio : MonoBehaviour
{
     public GameObject Musica;
    Scene scene;
    private void Update()
    {
        scene = SceneManager.GetActiveScene();
        if (scene.name == "Transicion 1" || scene.name == "Transicion 2" || scene.name == "Transicion 3" || scene.name == "Transicion 4" || scene.name == "Transicion 5" || scene.name == "Fuego" || scene.name == "Diamantes" || scene.name == "Temperatura" || scene.name == "CablesFixed" || scene.name == "nombre")
        {
            Musica.SetActive(false);
        }
        else if(scene.name == "Selector_Planetas" || scene.name == "HD_85512" || scene.name == "Cancri_e" || scene.name == "Kepler_16_b" || scene.name == "OGLE-2005-BLG-390Lb" || scene.name == "Kepler_22b")
        {
            Musica.SetActive(true);
        }
    }
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        
    }
  
}
