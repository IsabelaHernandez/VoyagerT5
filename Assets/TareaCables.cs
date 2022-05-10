using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TareaCables : MonoBehaviour
{
    public int conexionesActuales;
    public GameObject caja, exito;

    [SerializeField] GameObject tareaCables;
    
    public void ComprobarVictoria()
    {
        if (conexionesActuales == 4)
        {
            Destroy(caja, 0.99f);
            Destroy(tareaCables, 1f);

            Invoke(nameof(Exito), 1f);
       
        }
      
    }
    
    public void Exito() { exito.SetActive(true); }


}