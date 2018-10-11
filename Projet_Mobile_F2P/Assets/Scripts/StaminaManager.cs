using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StaminaManager : MonoBehaviour {

    public float MaxStamina;
    [SerializeField] private float currentStamina;
    public int FirstStarNeedsStamina;
    public int SecondStarNeedsStamina;
    public int ThirdStarNeedsStamina;
    public SwapMove my_SwapMove;
    public Image StaminaImg;


	// Use this for initialization
	void Start () {
        currentStamina = MaxStamina;
	}
	
	// Update is called once per frame
	void Update () {
        /*
		if(my_SwapMove.is_Moving || my_SwapMove.is_Standing)
        {
            UpdateStamina();
        }
        */

	}

    public void UpdateStamina()
    {
        //my_SwapMove.is_Moving = false;
        my_SwapMove.is_Standing = false;
        currentStamina--;
        ShowStamina();
        CheckActualStamina();
    }

    void ShowStamina()
    {
        StaminaImg.fillAmount = (currentStamina / MaxStamina);
    }

    void CheckActualStamina()
    {
        if(currentStamina <= 0)
        {
            Debug.Log("Robot explosed");
            //Show Loose Menu
        }
        if(currentStamina >= FirstStarNeedsStamina && currentStamina <= SecondStarNeedsStamina)
        {
            Debug.Log("Get 1st star");
        }

        if (currentStamina >= SecondStarNeedsStamina && currentStamina <= ThirdStarNeedsStamina)
        {
            Debug.Log("Get 2nd star");
        }

        if(currentStamina >= ThirdStarNeedsStamina)
        {
            Debug.Log("Get 3rd star");
        }
    }


}
