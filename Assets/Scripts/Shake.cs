using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public MovPlaneta movPlaneta;
    public float duration = 1f;
    public bool start = false;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && movPlaneta.stop == 0)
        {
            start = true;
            StartCoroutine(Shaking());

        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            start = false;
            StartCoroutine(Shaking());
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
}
