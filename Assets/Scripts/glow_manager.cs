using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glow_manager : MonoBehaviour
{
    public Material glow, nonglow;
    bool isGlowing = false;

    
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
