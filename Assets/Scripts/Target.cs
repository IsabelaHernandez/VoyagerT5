using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Target : MonoBehaviour
{
   public float rayLength;
   public LayerMask LayerMask;
   public GameObject punto1;
   public GameObject punto2;
   public GameObject punto3;
   public GameObject punto4;
    // Start is called before the first frame update
    void Start()
    {
        reiniciarVentanas();

         // renderer = GetComponent<Renderer>();
        // RaycastHit hit;
    }

// Update is called once per frame
private void Update()
    {
        if(Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            RaycastHit hit;
            Ray ray =  Camera.main.ScreenPointToRay(Input.mousePosition );
            if (Physics.Raycast(ray,out hit, rayLength, LayerMask))                 //cuando el raycast choca contra la "layer" de los puntos esta activa el ui
            {
                if (hit.collider.name == "Puntos_1")
                {
                    reiniciarVentanas();
                    Debug.Log("punto 2 pa");
                    ventanaPunto1();
                }
                if (hit.collider.name == "Puntos_2")
                {
                    reiniciarVentanas();
                    Debug.Log("punto 2 pa");
                    ventanaPunto2();
                }

                if (hit.collider.name == "Puntos_3")
                {
                    reiniciarVentanas();
                    Debug.Log("punto 3 pa");
                    ventanaPunto3();
                }

                if (hit.collider.name == "Puntos_4")
                {
                    reiniciarVentanas();
                    Debug.Log("punto 4 pa");
                    ventanaPunto4();
                }
            }
        }

      void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = Color.yellow;
    }

     void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }

    }

    public void reiniciarVentanas()             // esta funcion hace que el ui de los puntos interactivos se cierre
    {
        punto1.SetActive(false);
        punto2.SetActive(false);
        punto3.SetActive(false);
        punto4.SetActive(false);
    }

    public void ventanaPunto1()               // activa el ui del punto 1 ....
    {
        punto1.SetActive(true);
    }

    public void ventanaPunto2()
    {
        punto2.SetActive(true);
    }

    public void ventanaPunto3()
    {
        punto3.SetActive(true);
    }

    public void ventanaPunto4()
    {
        punto4.SetActive(true);
    }
}
