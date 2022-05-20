using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glow_manager : MonoBehaviour
{
    public Material glow, nonglow;
    bool isGlowing = false;
    public GameObject Text_HD;
    public GameObject Text_Cancri;
    public GameObject Text_Kepler16;
    public GameObject Text_Kepler22;
    public GameObject Text_Ogle;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

      private void OnMouseEnter()
        {
            gameObject.GetComponent<MeshRenderer>().material = glow;

        }
        
        private void OnMouseExit()
        {
            gameObject.GetComponent<MeshRenderer>().material = nonglow;
        }

    /*void ToogleGlow()
    {
        if (isGlowing)
        {
            gameObject.GetComponent<MeshRenderer>().material = nonglow;
            isGlowing = false;
        }
        else
        {
            gameObject.GetComponent<MeshRenderer>().material = glow;
            isGlowing = true;
        }
    }*/
}
