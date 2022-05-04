using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Este script DEBE estar colocado en la bolsa
public class TareaDiamantes : MonoBehaviour
{
    int placedDiamonds = 0; // Cantidad de diamantes
    [SerializeField] Sprite[] bagSprites; // Array de sprites (Ajustados desde el inspector (SerializeField) )

    SpriteRenderer sp; // Referencia al Spriterenderer

    private void Start()
    {
        // Obtener el componente del Spriterenderer
        sp = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Si se detecta colisión con un Diamante se llamará AddDiamond
        if (collision.gameObject.GetComponent<Diamante>() != null) AddDiamond(collision.gameObject);
    }

    // AddDiamond se encarga de "colocar" el diamante en la bolsa, cambiar la apariencia de la bolsa y desaparecer los diamantes colocados
    // ademasd de cambiar de escena una vez todos los diamantes hayan sido depositados
    void AddDiamond(GameObject diamond)
    {
        diamond.SetActive(false);
        placedDiamonds++;

        // Colocar un sprite distinto dependiendo de cuantos diamantes se han metido a la escena
        switch(placedDiamonds)
        {
            case 1:
                sp.sprite = bagSprites[0];
                break;
            case 2:
                sp.sprite = bagSprites[1];
                break;
            case 3:
                sp.sprite = bagSprites[2];
                break;
            case 4:
                sp.sprite = bagSprites[3];
                break;
            case 5:
                sp.sprite = bagSprites[4];
                break;
        }

        // Dentro de este coloquen la lógica de lo que debe pasar una vez todos los diamantes se hayan
        // guardado en la bolsa
        if (placedDiamonds == 5)
        {
            // Cambio de escena ?
            print("Cambio de escena");
            // !! Recuerden colocar el cambio de la escena por medio de SceneManager.LoadScene() !!
        }
    }
}
