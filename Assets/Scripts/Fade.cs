using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
    public GameObject FadeShit;
    public float duracionFade;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DeactivateFade());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator DeactivateFade()
    {
        yield return new WaitForSeconds(duracionFade);
        FadeShit.SetActive(false);
    }
    public void ActivateFade()
    {
        //FadeShit.SetActive(true);
    }

}
