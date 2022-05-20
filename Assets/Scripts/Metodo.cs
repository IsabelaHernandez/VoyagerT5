using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Metodo : MonoBehaviour
{
    public UnityEngine.Video.VideoPlayer video;
    // Start is called before the first frame update
    void Start()
    {
        video.SetDirectAudioVolume(1, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
