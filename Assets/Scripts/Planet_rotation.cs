using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet_rotation : MonoBehaviour
{
    public GameObject Planet;
    public float velocidadRotacion;
    public float Xrotation;
    public float Yrotation;
    public float Zrotation;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(Xrotation * Time.deltaTime, Yrotation * Time.deltaTime, Zrotation * Time.deltaTime));

        if (Input.GetKey("a"))
        {
            this.Planet.GetComponent<Transform>().transform.Rotate(0,-velocidadRotacion*Time.deltaTime,0,Space.Self);
        }
        else
        {
           transform.Rotate(new Vector3(Xrotation * Time.deltaTime, Yrotation * Time.deltaTime, Zrotation * Time.deltaTime));
        }
        if (Input.GetKey("d"))
        {
            this.Planet.GetComponent<Transform>().transform.Rotate(0,velocidadRotacion*Time.deltaTime, 0, Space.Self);
        }
        else
        {
            transform.Rotate(new Vector3(Xrotation * Time.deltaTime, Yrotation * Time.deltaTime, Zrotation * Time.deltaTime));
        }

    }
}
