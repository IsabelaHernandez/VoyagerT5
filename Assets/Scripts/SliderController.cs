using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderController : MonoBehaviour
{
    [SerializeField]
    private Termometro slider;

    [Space]
    [SerializeField]
    [Range(-1, 1)]
    private float position;
    [SerializeField]
    private float speed;
    [SerializeField]
    private float centerRange;

    private int dir = -1;

    public bool active;

    private void Start()
    {
        slider.Init(centerRange);
    }

    private void Update()
    {
        if (active)
        {
            UpdatePosition();
            slider.UpdateSlider(position);
        }
    }

    private void UpdatePosition()
    {
        position += dir * Time.deltaTime * speed;

        if (position * dir >= 1)
        {
            position = dir;
            dir *= -1;
        }
    }

    public bool CheckHit()
    {
        return Mathf.Abs(position) <= centerRange / 2;
    }

    public void Stop()
    {
        active = false;
        
    }

    public void Restart()
    {
        active = true;

        dir = -1;
        position = 0;
    }
}

