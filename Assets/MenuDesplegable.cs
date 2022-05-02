using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuDesplegable : MonoBehaviour
{
    public RectTransform PanelGeneral; //lo que se mueve
    float PosFinal = 90; //mover y
    bool abrirMenu = true; //desplpegado o no
    public float tiempo = 0.5f; //t en el que va a pasar

    IEnumerator Mover(float time, Vector3 posInit, Vector3 posFin) //controlar t, pos
    {

        float elapsedTime = 0;
        while (elapsedTime < time) //
        {
            PanelGeneral.position = Vector3.Lerp(posInit, posFin, (elapsedTime / time));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        PanelGeneral.position = posFin;
    }


    void MoverMenu(float time, Vector3 posInit, Vector3 posFin)
    {
        StartCoroutine(Mover(time, posInit, posFin));
    }

    public void BUTTON_Interfaz()
    {
        int signo = 0;
        if (!abrirMenu) signo = -736; //ocultar (izq)

        print(new Vector3(signo + PosFinal, PanelGeneral.position.x, 0));
        MoverMenu(tiempo, PanelGeneral.position, new Vector3(PanelGeneral.position.x, signo + PosFinal, 0)); //saber a que lado va
        abrirMenu = !abrirMenu;
    }
}
