using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Planet_selector : MonoBehaviour
{
    public float rayLength;
    public LayerMask LayerMask;
    public Animator transitionAnimator;
    public float transitionTime = 2f;
    public AudioSource sonidoPuerta;

    public GameObject Text_HD;
    public GameObject Text_Cancri;
    public GameObject Text_Kepler16;
    public GameObject Text_Kepler22;
    public GameObject Text_Ogle;

    void Start()
    {
        reiniciarVentanas();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, rayLength, LayerMask))                 //cuando el raycast choca contra la "layer" de los puntos esta activa el ui
            {
                if (hit.collider.name == "Mesh_HD_85512")
                {
                    StartCoroutine(SceneLoad("Transicion1 1"));
                }
                if (hit.collider.name == "Mesh_Cancri_e")
                {
                    StartCoroutine(SceneLoad("Transicion1 2"));
                }
                if (hit.collider.name == "Mesh_Kepler_16b")
                {
                    StartCoroutine(SceneLoad("Transicion1 3"));
                }
                if (hit.collider.name == "Mesh_Kepler_22b")
                {
                    StartCoroutine(SceneLoad("Transicion1 4"));
                }
                if (hit.collider.name == "Mesh_OGLE_2005")
                {
                    StartCoroutine(SceneLoad("Transicion1 5"));
                }

            }
        }

        if (!EventSystem.current.IsPointerOverGameObject())
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, rayLength, LayerMask))                 //cuando el raycast choca contra la "layer" de los puntos esta activa el ui
            {
                if (hit.collider.name == "Mesh_HD_85512")
                {
                    reiniciarVentanas();
                    Text_HD.SetActive(true);
                    Debug.Log("hd text");
                }
                if (hit.collider.name == "Mesh_Cancri_e")
                {
                    reiniciarVentanas();
                    Text_Cancri.SetActive(true);
                }
                if (hit.collider.name == "Mesh_Kepler_16b")
                {
                    reiniciarVentanas();
                    Text_Kepler16.SetActive(true);
                }
                if (hit.collider.name == "Mesh_Kepler_22b")
                {
                    reiniciarVentanas();
                    Text_Kepler22.SetActive(true);
                }
                if (hit.collider.name == "Mesh_OGLE_2005")
                {
                    reiniciarVentanas();
                    Text_Ogle.SetActive(true);
                }

            }
        }
    }

    public void reiniciarVentanas()             // esta funcion hace que el ui de los puntos interactivos se cierre
    {
        Text_HD.SetActive(false);
        Text_Cancri.SetActive(false);
        Text_Kepler16.SetActive(false);
        Text_Kepler22.SetActive(false);
        Text_Ogle.SetActive(false);
    }

    public IEnumerator SceneLoad(string nombreEscena)
    {
        transitionAnimator.SetTrigger("StartTransition");
        sonidoPuerta.Play();
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(nombreEscena);

    }
}
