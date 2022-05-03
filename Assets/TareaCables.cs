using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TareaCables : MonoBehaviour
{
    public int conexionesActuales;
    public GameObject caja;

    public void ComprobarVictoria()
    {
        if (conexionesActuales == 4)
        {
            Destroy(caja, 0.99f);
            Destroy(this.gameObject, 1f);
            
        }
    }
}