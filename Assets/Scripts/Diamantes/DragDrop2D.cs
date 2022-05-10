
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop2D : MonoBehaviour
{
    RaycastHit2D hit;
    Camera cam;
    Vector3 pos;
    Vector3 mousePos;
    Transform focus;
    bool isDrag;

    private void Start()
    {
        isDrag = false;
        cam = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hit = Physics2D.GetRayIntersection(cam.ScreenPointToRay(Input.mousePosition));

            if (hit.collider != null)
            {
                focus = hit.transform;
                print("Clickeado =" + hit.collider.transform.name);
                isDrag = true;
            }
        }
        else if (Input.GetMouseButtonUp(0) && isDrag == true)
        {
            isDrag = false;
        }
        else if (isDrag == true)
        {
            mousePos = Input.mousePosition;
            mousePos.z = -cam.transform.position.z;
            pos = cam.ScreenToWorldPoint(mousePos);

            focus.position = new Vector3(pos.x, pos.y, focus.position.z);

        }
    }
}
