using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class VelocidadFlujo : MonoBehaviour
{
    public VisualEffect warpSpeedVFX;
    private bool warpActive;
    public float rate = 0.02f;


    void Start()
    {
        warpSpeedVFX.Stop();
        warpSpeedVFX.SetFloat("HyperFlujo", 0);

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            warpActive = true;
            StartCoroutine(ActivateParticles());
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            warpActive = false;
            StartCoroutine(ActivateParticles());

        }
    }

    IEnumerator ActivateParticles()
    {
        if (warpActive)
        {
            warpSpeedVFX.Play();
            float cantidad = warpSpeedVFX.GetFloat("HyperFlujo");
            while (cantidad < 1 & warpActive)
            {
                cantidad += rate;
                warpSpeedVFX.SetFloat("HyperFlujo", cantidad);
                yield return new WaitForSeconds (0.1f);
            }
        }
        else
        {
            float cantidad = warpSpeedVFX.GetFloat("HyperFlujo");
            while (cantidad > 0 &! warpActive)
            {
                cantidad -= rate;
                warpSpeedVFX.SetFloat("HyperFlujo", cantidad);
                yield return new WaitForSeconds(0.1f);
                if(cantidad <= 0 + rate)
                {
                    cantidad = 0;
                    warpSpeedVFX.SetFloat("HyperFlujo", cantidad);
                    warpSpeedVFX.Stop();

                }
            }
        }
    }

}
