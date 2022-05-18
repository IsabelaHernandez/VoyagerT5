using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public MovPlaneta movPlaneta;
    public float duration = 1f;
    public bool start = false;
    public GameObject panel;
    public Transform target;
    public Transform target2;
    public float speed;
    void Start()
    {
        //target2.position = panel.transform.position;
    }

    void Update()
    {
        float step = speed * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && movPlaneta.stop == 0)
        {
            start = true;
            StartCoroutine(Shaking());
            while (Input.GetKeyDown(KeyCode.Space) && movPlaneta.stop == 0) { panel.transform.position = Vector3.MoveTowards(panel.transform.position, target.position, step); }

        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            start = false;
            StartCoroutine(Shaking());
            while (Input.GetKeyUp(KeyCode.Space)) { panel.transform.position = Vector3.MoveTowards(panel.transform.position, target2.position, step); }
        }

        /*if (start)
        {
            start = false;
            StartCoroutine(Shaking());
        }*/

    }
    IEnumerator Shaking()
    {

        Vector3 startPosition = transform.position;
        //float elapsedTime = 0f;
        while (start && movPlaneta.stop == 0)
        {
            //elapsedTime += Time.deltaTime;
            transform.position = startPosition + Random.insideUnitSphere * 3.5f;
            yield return null;
        }
        transform.position = startPosition;
    }
    /*void Accelerate()
    {
        float step = speed * Time.deltaTime;
        if (start) { panel.transform.position = Vector3.MoveTowards(panel.transform.position, target.position, step); }
    }
    void Deaccelerate()
    {
        float step = speed * Time.deltaTime;
        panel.transform.position = Vector3.MoveTowards(panel.transform.position, target2.position, step);
    }*/
}
