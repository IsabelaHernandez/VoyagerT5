using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_zoom_in : MonoBehaviour
{

    public Transform[] views;
    public float transitionSpeed;
    Transform currentView;
    // Start is called before the first frame update
    void Start()
    {
       currentView = transform;
       currentView = views[1];
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetButton("Horizontal")||Input.GetButton("Horizontal"))
      {
          currentView = views[0];
      }
        else
        {
           currentView = views[1];
        }
    }
    private void LateUpdate()
    {
       transform.position = Vector3.Lerp(transform.position, currentView.position, Time.deltaTime * transitionSpeed);
    }
}
