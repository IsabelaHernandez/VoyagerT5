using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TareaFuego : MonoBehaviour
{
    [SerializeField] Victoria scriptVictoria;
    [SerializeField] float deltaSize;

    private void OnMouseDown()
    {
        gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x - deltaSize, gameObject.transform.localScale.y - deltaSize, gameObject.transform.localScale.z - deltaSize);
        if (gameObject.transform.localScale.x <= 0)
        {
            Destroy(gameObject);
            scriptVictoria.contadorFueguitos--;
            scriptVictoria.Ganar();
            Debug.Log("clear");
        }
    }
}
