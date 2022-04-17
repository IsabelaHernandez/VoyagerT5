using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds_rotation : MonoBehaviour
{
    public float Xrotation;
    public float Yrotation;
    public float Zrotation;
   // public GameObject Clouds;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(Xrotation*Time.deltaTime, Yrotation *Time.deltaTime, Zrotation *Time.deltaTime));
        //GetComponent<Transform>().rotation.x     
    }
}
