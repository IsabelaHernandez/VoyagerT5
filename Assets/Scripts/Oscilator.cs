using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Oscilator : MonoBehaviour
{
    public GameObject objetoAMover;
    public Transform target;
    public Transform target2;
    //public AudioSource sonidoOn;
    //public AudioSource sonidoOff;


    public float speed;
    bool isActivated;
    private void Start()
    {
        isActivated = true;        
    }
    void Update()
    {
        float step = speed * Time.deltaTime;
        if (isActivated == true) { objetoAMover.transform.position = Vector3.MoveTowards(objetoAMover.transform.position, target.position, step);  }
        if (objetoAMover.transform.position == target.position) { isActivated = false; }
        if (isActivated == false) { objetoAMover.transform.position = Vector3.MoveTowards(objetoAMover.transform.position, target2.position, step); }
        if (objetoAMover.transform.position == target2.position) { isActivated = true; }

    }
}
