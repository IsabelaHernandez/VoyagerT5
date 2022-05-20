using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private SliderController sliderController;
    [SerializeField]
    private Text infoText;
    [SerializeField]
    private Image gameFeedbackImage;
    [SerializeField]
    private Sprite winSprite;
    [SerializeField]
    private Sprite loseSprite;
    [SerializeField]
    private Sprite startSprite;
    [SerializeField]
    private Animator[] hielosAnimator;
    [SerializeField]
    private AudioClip winAudio;
    [SerializeField]
    private AudioClip loseAudio;
    [SerializeField]
    private AudioClip iceBreakAudio;
    [SerializeField]
    private AudioSource audioPlayer;

    [Space]
    [SerializeField]
    private int targetHits = 3;
    [SerializeField]
    private float resetDelay = 1;
    [SerializeField]
    private float startDelay = 1;
    [SerializeField]
    private float WinDelay = 1;
    [SerializeField]
    private float iceMinDelay = 1;
    [SerializeField]
    private float iceMaxDelay = 1;

    private int currentHits;
    public GameObject boton;
    public AudioSource hit;
    private void Start()
    {
        UpdateHits();
        //StartCoroutine(StartSlider());
        foreach (Animator anim in hielosAnimator)
        {
            anim.SetBool("QuitarHielo", false);
        }
    }

    private void Update()
    {
        if (sliderController.Active)
        {
        UpdateInput();
        }
    }

    private void UpdateInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            sliderController.Stop();

            if (sliderController.CheckHit())
            {
                OnHit();
            }
            else
            {
                OnFail();
                StartCoroutine(RestartSlider());
            }

        }
    }

    private void OnHit()
    {
            currentHits++;
            hit.Play();
            UpdateHits();
        

        if (currentHits >= targetHits)
        {
            currentHits = 0;

            print("Win");
            gameFeedbackImage.gameObject.SetActive(true);
            gameFeedbackImage.sprite = winSprite;
            boton.SetActive(true);
            StartCoroutine(WinSlider());
        }
        else
        {
            print("Current hits: " + currentHits);
            StartCoroutine(RestartSlider());
        }
    }

    private void OnFail()
    {
        currentHits = 0;
        UpdateHits();

        print("Lose");
        audioPlayer.PlayOneShot(loseAudio);
        gameFeedbackImage.gameObject.SetActive(true);
        gameFeedbackImage.sprite = loseSprite;
    }

    private void UpdateHits()
    {
        infoText.text = $"CURRENT HITS: {currentHits}";
    }

    private IEnumerator RestartSlider()
    {
        sliderController.Stop();

        yield return new WaitForSeconds(resetDelay);

        gameFeedbackImage.gameObject.SetActive(false);
        sliderController.Restart();
        UpdateHits();
    }

    /*private IEnumerator StartSlider()
    {
        gameFeedbackImage.sprite = startSprite;
        yield return new WaitForSeconds(startDelay);
        sliderContro ller.Restart();
        gameFeedbackImage.gameObject.SetActive(false);
    }*/

    private IEnumerator WinSlider()
    {
        sliderController.Stop();
        audioPlayer.PlayOneShot(winAudio);
        foreach (Animator anim in hielosAnimator)
        {
            anim.SetBool("QuitarHielo", true);
            audioPlayer.PlayOneShot(iceBreakAudio);
            yield return new WaitForSeconds(Random.Range(iceMinDelay,iceMaxDelay));
        }
        yield return new WaitForSeconds(resetDelay); 
        //pasar a siguiente escena
    }
}