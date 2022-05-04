using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

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
                if (hit.collider.name == "Mesh_HD_85512")
                {
                    SceneManager.LoadScene("HD_85512");
                }
                if (hit.collider.name == "Mesh_Cancri_e")
                {
                    SceneManager.LoadScene("Cancri_e");
                }
                if (hit.collider.name == "Mesh_Kepler_16b")
                {
                    SceneManager.LoadScene("Kepler_16_b");
                }
                if (hit.collider.name == "Mesh_Kepler_22b")
                {
                    SceneManager.LoadScene("Kepler_22b");
                }
                if (hit.collider.name == "Mesh_OGLE_2005")
                {
                    SceneManager.LoadScene("OGLE-2005-BLG-390Lb");
                }

            }
        }
    }
}
