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
    public float duracion;

    public float speed;
    bool isActivated;
    private void Start()
    {
        isActivated = true;        
    }
    void Update()
    {
        float step = speed * Time.deltaTime;
        if (isActivated == true) { objetoAMover.transform.position = Vector3.MoveTowards(objetoAMover.transform.position, target2.position, step);StartCoroutine(falsee()); }
        //if (objetoAMover.transform.position == target2.position) { isActivated = false; Debug.Log("isActivated false"); }
        if (isActivated == false) { objetoAMover.transform.position = Vector3.MoveTowards(objetoAMover.transform.position, target.position, step); StartCoroutine(truee()); }
        //if (objetoAMover.transform.position == target.position) { isActivated = true; Debug.Log("isActivated true"); }
        if (Input.GetKeyDown(KeyCode.Space)){ Destroy(objetoAMover); }


    }
    IEnumerator falsee()
    {
        yield return new WaitForSeconds(duracion);
        Debug.Log("False");
        if (isActivated) { isActivated = false; }      
    }
    IEnumerator truee()
    {
        yield return new WaitForSeconds(duracion);
Debug.Log("True");
        if (!isActivated) { isActivated = true; }
    }
}
