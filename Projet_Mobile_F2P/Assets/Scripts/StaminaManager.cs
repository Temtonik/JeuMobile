﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StaminaManager : MonoBehaviour {

    public float MaxStamina;
    public float currentStamina;
    public int FirstStarNeedsStamina;
    public int SecondStarNeedsStamina;
    public int ThirdStarNeedsStamina;
    public SwapMove my_SwapMove;
    public Image StaminaImg;
    public GameObject Defeate;
    public GameObject pauseButton;
    public GameObject staminaBar;
    public SoundManager my_SM;

    public Image FirstStar;
    public Image SecondStar;
    public Image ThirdStar;


    // Use this for initialization
    void Start () {
        currentStamina = MaxStamina;
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void UpdateStamina()
    {
        my_SwapMove.is_Moving = false;
        my_SwapMove.is_Standing = false;
        currentStamina--;
        ShowStamina();
        CheckActualStamina();
    }

    public void ShowStamina()
    {
        StaminaImg.fillAmount = (currentStamina / MaxStamina);
    }

    public void CheckActualStamina()
    {
        if(currentStamina <= 0)
        {
            my_SM.PlayDieSound();
            Time.timeScale = 0;
            Defeate.SetActive(true);
            pauseButton.SetActive(false);
            staminaBar.SetActive(false);
        }
        if(currentStamina >= FirstStarNeedsStamina && currentStamina <= SecondStarNeedsStamina)
        {
            Debug.Log("Get 1st star");
            FirstStar.fillAmount = 1;
        }

        if (currentStamina >= SecondStarNeedsStamina && currentStamina <= ThirdStarNeedsStamina)
        {
            Debug.Log("Get 2nd star");
            FirstStar.fillAmount = 1;
            SecondStar.fillAmount = 1;
        }

        if(currentStamina >= ThirdStarNeedsStamina)
        {
            Debug.Log("Get 3rd star");
            FirstStar.fillAmount = 1;
            SecondStar.fillAmount = 1;
            ThirdStar.fillAmount = 1;
        }
    }
}
