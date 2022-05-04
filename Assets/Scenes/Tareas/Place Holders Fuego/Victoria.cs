using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victoria : MonoBehaviour
{
    public GameObject VictoriaText;
    public static GameObject VictoriaImagen;

    void start()
    {
        Victoria.VictoriaImagen = VictoriaText;
        Victoria.VictoriaImagen.gameObject.SetActive (false);
    }

    void update()
    {
        Victoria.VictoriaImagen.gameObject.SetActive (true);
    }
}

