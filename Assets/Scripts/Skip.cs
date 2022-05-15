using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Skip : MonoBehaviour
{
    public int numeroEscena;
    public Animator transitionAnimator;
    public float transitionTime = 1f;
    public bool hayPuerta = false;
    public AudioSource sonidoPuerta;
    private void Start()
    {
        //sonidoPuerta = GetComponent<AudioSource>();
    }
    void Update()
    {
        if(numeroEscena == 4 || numeroEscena == 6 || numeroEscena == 9 || numeroEscena == 12 || numeroEscena == 15 || numeroEscena == 18)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                LoadScene();               
            }
        }
       
    }
    public void LoadScene()
    {
        if (hayPuerta == true) { sonidoPuerta.Play(); }
        StartCoroutine(SceneLoad(numeroEscena));

    }
    public IEnumerator SceneLoad(int numeroEscena)
    {
        transitionAnimator.SetTrigger("StartTransition");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(numeroEscena);

    }
}
