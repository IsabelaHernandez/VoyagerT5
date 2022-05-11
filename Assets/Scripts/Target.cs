using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Target : MonoBehaviour
{
   // private Renderer ren

   public float rayLength;
   public LayerMask LayerMask;
   public GameObject punto1;
   public GameObject punto2;
   public GameObject punto3;
   public GameObject punto4;

    public AudioClip sonidoClick;
    AudioSource reproductorSonidos;
    // Start is called before the first frame update
    void Start()
    {
        reiniciarVentanas();
        Cursor.lockState = CursorLockMode.None;

        reproductorSonidos = GetComponent<AudioSource>();
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
                    reproductorSonidos.PlayOneShot(sonidoClick);
                    reiniciarVentanas();
                    Debug.Log("punto 1 pa");
                    ventanaPunto1();
                }
                if (hit.collider.name == "Puntos_2")
                {
                    reproductorSonidos.PlayOneShot(sonidoClick);
                    reiniciarVentanas();
                    Debug.Log("punto 2 pa");
                    ventanaPunto2();
                }

                if (hit.collider.name == "Puntos_3")
                {
                    reproductorSonidos.PlayOneShot(sonidoClick);
                    reiniciarVentanas();
                    Debug.Log("punto 3 pa");
                    ventanaPunto3();
                }

                if (hit.collider.name == "Puntos_4")
                {
                    reproductorSonidos.PlayOneShot(sonidoClick);
                    reiniciarVentanas();
                    Debug.Log("punto 4 pa");
                    ventanaPunto4();
                }
            }
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
