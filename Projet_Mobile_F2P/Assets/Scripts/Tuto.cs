using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuto : MonoBehaviour {

    public GameObject TutoGyro;
    public GameObject TutoSwipeUp;
    public GameObject TutoSwipeDown;

    public SwapMove my_SwapMove;
    private bool swipeDownActivated;

    // Use this for initialization
    void Start () {
        StartCoroutine(ShowTutoGyro());
	}
	
	// Update is called once per frame
	void Update () {
        if (my_SwapMove.is_Moving && !swipeDownActivated)
        {
            StartCoroutine(ShowTutoSwipeDown());
            swipeDownActivated = true;
        }
	}

    IEnumerator ShowTutoGyro()
    {
        yield return new WaitForSeconds(1f);
        TutoGyro.SetActive(true);
        StartCoroutine(ShowTutoSwipeUp());

    }

    IEnumerator ShowTutoSwipeUp()
    {

        yield return new WaitForSeconds(2f);
        TutoGyro.SetActive(false);
        TutoSwipeUp.SetActive(true);
        StartCoroutine(HideTutoSwipeUp());
    }

    IEnumerator HideTutoSwipeUp()
    {
        yield return new WaitForSeconds(2f);
        TutoSwipeUp.SetActive(false);
    }

    IEnumerator ShowTutoSwipeDown()
    {
        yield return new WaitForSeconds(0.5f);
        TutoSwipeUp.SetActive(false);
        TutoSwipeDown.SetActive(true);
        StartCoroutine(HideTutoSwipeDown());
    }

    IEnumerator HideTutoSwipeDown()
    {
        yield return new WaitForSeconds(2f);
        TutoSwipeDown.SetActive(false);
    }
}
