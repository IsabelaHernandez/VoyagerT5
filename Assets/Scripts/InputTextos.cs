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

    float timeElapsed;
    public GameObject ttextoSalida;
    public Button boton;
    public GameObject final2;
    public GameObject input;
    public GameObject skipcito;
    public bool count;
    void Start()
    {
        count = false;
    }

    // Update is called once per frame
    void Update()
    {
        boton.onClick.AddListener(Textos);
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
}
