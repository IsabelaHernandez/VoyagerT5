using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectPull : MonoBehaviour
{
    public GameObject objetoAMover;
    public Transform target;
    public Transform target2;
    public AudioSource sonidoOn;
    public AudioSource sonidoOff;


    public float speed;
    bool isActivated;
    public Button boton;

    private void Start()
    {
        isActivated = false;
        boton.onClick.AddListener(On);
        //boton.onClick.AddListener(Off);

    }
    void Update()
    {
        float step = speed * Time.deltaTime;
        if (isActivated == true) { objetoAMover.transform.position = Vector3.MoveTowards(objetoAMover.transform.position, target.position, step); }
        if (isActivated == false) { objetoAMover.transform.position = Vector3.MoveTowards(objetoAMover.transform.position, target2.position, step); }

    }
    void On()
    {
        if (isActivated == false) { isActivated = true; sonidoOn.Play(); }
        else { isActivated = false; sonidoOff.Play(); }
    }
    void Off()
    {
        //if (isActivated == true) { isActivated = false; }
    }


}
