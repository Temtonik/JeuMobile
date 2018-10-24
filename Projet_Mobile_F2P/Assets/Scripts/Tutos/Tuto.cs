using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuto : MonoBehaviour {

    public GameObject TutoGyro;
    public GameObject TutoSwipeUp;
    public GameObject TutoSwipeDown;

    public SwapMove my_SwapMove;
    private bool swipeDownActivated;
    private AudioSource Audiosource;
    public AudioClip SndGyro;
    public AudioClip SndSwipeUp;
    public AudioClip SndSwipeDown;

    // Use this for initialization
    void Start () {
        Audiosource = GetComponent<AudioSource>();
        StartCoroutine(ShowTutoGyro());
	}
	
	// Update is called once per frame
	void Update () {
        if (my_SwapMove.is_Moving && !swipeDownActivated)
        {
            
            swipeDownActivated = true;
        }
	}

    IEnumerator ShowTutoGyro()
    {
        yield return new WaitForSeconds(0.3f);
        TutoGyro.SetActive(true);
        PlayGyroSound();
        StartCoroutine(ShowTutoSwipeUp());

    }

    IEnumerator ShowTutoSwipeUp()
    {

        yield return new WaitForSeconds(4.5f);
        TutoGyro.SetActive(false);
        TutoSwipeUp.SetActive(true);
        PlaySwipeUpSound();
        StartCoroutine(HideTutoSwipeUp());
    }

    IEnumerator HideTutoSwipeUp()
    {
        yield return new WaitForSeconds(3f);
        TutoSwipeUp.SetActive(false);
        StartCoroutine(ShowTutoSwipeDown());
    }

    IEnumerator ShowTutoSwipeDown()
    {
        yield return new WaitForSeconds(0.5f);
        TutoSwipeUp.SetActive(false);
        TutoSwipeDown.SetActive(true);
        PlaySwipeDownSound();
        StartCoroutine(HideTutoSwipeDown());
    }

    IEnumerator HideTutoSwipeDown()
    {
        yield return new WaitForSeconds(6f);
        TutoSwipeDown.SetActive(false);
    }

    void PlayGyroSound()
    {
        Audiosource.clip = SndGyro;
        Audiosource.Play();
    }
    void PlaySwipeUpSound()
    {
        Audiosource.clip = SndSwipeUp;
        Audiosource.Play();
    }
    void PlaySwipeDownSound()
    {
        Audiosource.clip = SndSwipeDown;
        Audiosource.Play();
    }
}
