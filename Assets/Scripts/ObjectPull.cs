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
    public GameObject flechaTuto;
    public GameObject[] paneles;
    public GameObject botonLaunch;

    public float speed;
    public  bool isActivated;
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
        if (!isActivated)
        {
            paneles[0].SetActive(false);
            paneles[1].SetActive(false);
            paneles[2].SetActive(false);
            paneles[3].SetActive(false);
        }
    }
    void On()
    {
        if (isActivated == false) { isActivated = true; sonidoOn.Play(); flechaTuto.SetActive(true); botonLaunch.SetActive(true); }
        else { isActivated = false; sonidoOff.Play(); flechaTuto.SetActive(false);}
        
    }
    void Off()
    {
        //if (isActivated == true) { isActivated = false; }
    }


}
