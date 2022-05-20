using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    public float delay = 3f;
    float timeElapsed;
    public GameObject input;
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
            input.SetActive(true);
            stop = true;
        }
    }
}
