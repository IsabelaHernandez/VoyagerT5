using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Volumen : MonoBehaviour
{

    public Slider volumeSlider;
    public AudioMixer mixer;
    private float value;


    public void SetVolume()
    {
        mixer.SetFloat("volumen", volumeSlider.value);
    }

    // Start is called before the first frame update
    void Start()
    {
        mixer.GetFloat("volumen", out value);
        volumeSlider.value = value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
