using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Termometro : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer bar;
    [SerializeField]
    private Transform indicator;
    [SerializeField]
    private Transform area;

    [SerializeField]
    private float height;

    public void Init(float centerRange)
    {
        area.transform.localScale = new Vector3(area.transform.localScale.x, centerRange * height, area.transform.localScale.z);

        bar.size = new Vector2(height, bar.size.y);
    }

    public void UpdateSlider(float position)
    {
        indicator.localPosition = Vector3.up * height / 2 * position;
    }
}
