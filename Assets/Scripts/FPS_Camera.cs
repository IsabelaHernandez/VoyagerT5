using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_Camera : MonoBehaviour
{
    private new Transform camera;
    public Vector2 sensibility;
    public float minRotationY;
    public float maxRotationY;
    public float angleY;
    public float angleX;
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
            angleY = (camera.localEulerAngles.y + horizontal * sensibility.x +360) %360; //se encarga de que el angulo este entre 0 y 360
            if (angleY >180) 
            {
                angleY -=360  ;
            }
            angleY = Mathf.Clamp(angleY, -57, 124);
           // camera.localEulerAngles = Vector3.up* angleY;
            //transform.Rotate(Vector3.up * horizontal *sensibility);

        
       /* transform.Rotate(0,horizontal,0);
        transform.rotation = new Vector3(transform.rotation.x,Mathf.Clamp(transform.rotation.y,minRotationY,maxRotationY), transform.rotation.z);
        */
        }
        
        float vertical = Input.GetAxis("Mouse Y");
        if (vertical != 0)
        {
           angleX = (camera.localEulerAngles.x - vertical * sensibility.y + 360) % 360; //se encarga de que el angulo este entre 0 y 360
            if (angleX > 180) { angleX -= 360;}
            angleX = Mathf.Clamp(angleX, -80, 80);
        }
            camera.localEulerAngles = Vector3.right * angleX + Vector3.up*angleY;
    }
}
