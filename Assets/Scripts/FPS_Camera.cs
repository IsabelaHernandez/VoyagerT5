using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_Camera : MonoBehaviour
{
    private new Transform camera;
    public Vector2 sensibility;
    // Start is called before the first frame update
    void Start()
    {
        camera = transform.Find("Main Camera");
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Mouse X");
        if (horizontal != 0 )
        {
            transform.Rotate(Vector3.up * horizontal *sensibility);
        }
        float vertical = Input.GetAxis("Mouse Y");
        if (vertical != 0)
        {
            float angle = (camera.localEulerAngles.x - vertical * sensibility.y + 360) % 360;
            if (angle > 180) { angle -= 360;}
            angle = Mathf.Clamp(angle, -80, 80);

            camera.localEulerAngles = Vector3.right * angle;
            {

            }
        }
    }
}
