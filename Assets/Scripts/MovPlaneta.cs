using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlaneta : MonoBehaviour
{
    [SerializeField] public float moveSpeed = -15f;
    private CharacterController controller;
    private float isPressed = 0;
    public float stop = 0;
    public VelocidadFlujo velocidadFlujo;
    public AudioSource hyperJumpArrival;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        hyperJumpArrival = GetComponent<AudioSource>();
        stop = 0;
       
    }

    void Update()
    {
        if (transform.position.z <= -0.5f && stop == 0 )
        {
            stop = 1;
            velocidadFlujo.warpActive = false;
            velocidadFlujo.StartCoroutine(velocidadFlujo.ActivateParticles());
            moveSpeed = -2f;
            hyperJumpArrival.Play();
        }
        if (transform.position.z <= -0.9f && stop == 1)
        {
            isPressed = 0;
            moveSpeed = 0f;
        }
        if (Input.GetKeyDown(KeyCode.Space) && stop == 0)
        {
            isPressed = 1;
        }
        if (Input.GetKeyUp(KeyCode.Space) && stop == 0)
        {
            isPressed = 0;
        }
        float hInput = isPressed;
        Vector3 direction = new Vector3(0, 0, hInput);
        controller.Move(direction * moveSpeed * Time.deltaTime);
      
    }
}