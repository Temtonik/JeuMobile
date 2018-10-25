using System.Collections;
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
    public Image FourStar;
    public TriggerStar My_StartBonus;

    private DialogueManager myDM;


    // Use this for initialization
    void Start () {
        currentStamina = MaxStamina;
        myDM = GameObject.FindGameObjectWithTag("DialogueManager").GetComponent<DialogueManager>();
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
        if(currentStamina < 0)
        {
            currentStamina = 0;
            my_SM.PlayDieSound();
            Time.timeScale = 0;
            Defeate.SetActive(true);
            pauseButton.SetActive(false);
            staminaBar.SetActive(false);
        }

        if(currentStamina == 3)
        {
            myDM.PlayBatterieSound();
        }

        if(currentStamina >= MaxStamina)
        {
            currentStamina = MaxStamina;
        }

    }

    public void CheckStarsNumber()
    {
        Time.timeScale = 0;
        if (currentStamina >= FirstStarNeedsStamina && currentStamina <= SecondStarNeedsStamina)
        {
            Debug.Log("Get 1st star");
            FirstStar.fillAmount = 1;
            SecondStar.fillAmount = 0;
            ThirdStar.fillAmount = 0;
            ShopManager.Singleton.nbStar++;
        }

        if (currentStamina >= SecondStarNeedsStamina && currentStamina <= ThirdStarNeedsStamina)
        {
            Debug.Log("Get 2nd star");
            FirstStar.fillAmount = 1;
            SecondStar.fillAmount = 1;
            ThirdStar.fillAmount = 0;
            ShopManager.Singleton.nbStar += 2;
        }

        if (currentStamina >= ThirdStarNeedsStamina)
        {
            Debug.Log("Get 3rd star");
            FirstStar.fillAmount = 1;
            SecondStar.fillAmount = 1;
            ThirdStar.fillAmount = 1;
            ShopManager.Singleton.nbStar += 3;
        }

        if (My_StartBonus.StarBonus)
        {
            FirstStar.fillAmount = 1;
            SecondStar.fillAmount = 1;
            ThirdStar.fillAmount = 1;
            FourStar.fillAmount = 1;
            ShopManager.Singleton.nbStar += 4;
        }
    }
}
