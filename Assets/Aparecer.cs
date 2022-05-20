using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aparecer : MonoBehaviour
{
    public float delay = 8f;
    float timeElapsed;
    public GameObject texto;
    bool stop;
    void Start()
    {
        stop = false;
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > delay && stop == false)
        {
            texto.SetActive(true);
            stop = true;
        }
    }
}
