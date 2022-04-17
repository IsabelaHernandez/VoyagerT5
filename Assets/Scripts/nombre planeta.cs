using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nombreplaneta : MonoBehaviour
{
    public InputField inputText;

    public Text textoNombre;
    public GameObject botonAceptar;

    

    private void Update()
    {
        if(textoNombre.text.Length < 4)
        {
            botonAceptar.SetActive(false);
        }

        if(textoNombre.text.Length >= 4)
        {
            botonAceptar.SetActive(true);
        }
    }

    public void aceptar()
    {
        PlayerPrefs.SetString("nombre planeta", inputText.text);
    }
}
