using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction1 : MonoBehaviour
{
    public GameObject textoejemplo;

    public void start()
    {
        textoejemplo.SetActive(false);
    }

    public void OnMouseOver()
    {
        textoejemplo.SetActive(true);
    }

    public void OnMouseExit()
    {
        textoejemplo.SetActive(false);
    }
}
