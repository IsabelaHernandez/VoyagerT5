using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Planet_selector : MonoBehaviour
{
    public float rayLength;
    public LayerMask LayerMask;
    void Start()
    {
   
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, rayLength, LayerMask))                 //cuando el raycast choca contra la "layer" de los puntos esta activa el ui
            {
                if (hit.collider.name == "HD_85512")
                {
                  //  cargarEscenaHD();
                    Debug.Log("HD pa");
                }
                if (hit.collider.name == "Cancri_e")
                {
                   // cargarEscenaHD();
                    Debug.Log("Cancri pa");
                }

            }
        }
    }
}
