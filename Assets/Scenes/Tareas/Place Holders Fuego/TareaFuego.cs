using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TareaFuego : MonoBehaviour
{
    private void OnMouseDown()
    {
        gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x - 0.34f, gameObject.transform.localScale.y - 0.36f, gameObject.transform.localScale.z - 0.38f);
        if (gameObject.transform.localScale.x <= 0)
        {
            Destroy(gameObject);
            Debug.Log("clear");
        }
    }
}
