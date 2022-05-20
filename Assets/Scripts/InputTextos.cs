using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputTextos : MonoBehaviour
{
    public Text textoSalida;
    public Text textoEntrada;
    public float delay = 3f;
    public float delay2 = 5f;
    public float delay3 = 12f;

    float timeElapsed;
    public GameObject ttextoSalida;
    public Button boton;
    public Button skipBreve;
    public GameObject elverDaderoSkip;
    public GameObject final2;
    public GameObject final4;

    public GameObject input;
    public GameObject skipcito;
    public bool count;
    public bool go;
    void Start()
    {
        count = false;
        go = false;
    }

    // Update is called once per frame
    void Update()
    {
        boton.onClick.AddListener(Textos);
        skipBreve.onClick.AddListener(Saltar);

        if (count)
        {
            timeElapsed += Time.deltaTime;
            if (timeElapsed > delay && count)
            {
                ttextoSalida.SetActive(true);
                

            }
            if (timeElapsed > delay2 && count)
            {
                skipcito.SetActive(true);
                count = false;
                timeElapsed = 0f;
            }

        }
        if (go)
        {
            timeElapsed += Time.deltaTime;
            if (timeElapsed > delay3 && go)
            {                
                go = false;
                final4.SetActive(true);
                elverDaderoSkip.SetActive(true);


            }
        }
    }
    void Textos()
     {
        textoSalida.text = textoEntrada.text;
        final2.SetActive(true);
        input.SetActive(false);
        count = true;
    }
    void Saltar()
    {
        go = true;
    }
}
