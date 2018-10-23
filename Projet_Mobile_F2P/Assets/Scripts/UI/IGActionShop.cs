using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IGActionShop : MonoBehaviour {

    public GameObject canvasBonus;
    public GameObject canvasBuyAction;
    public GameObject canvasDefeatStamina;
    public GameObject pauseButton;

    public StaminaManager my_SM;
    public ShopManager my_ShopManager;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
     
	}

    public void CanvasBonus()
    {
        canvasBonus.SetActive(true);
        pauseButton.SetActive(false);
    }

    public void CanvasBuyAction()
    {
        canvasBuyAction.SetActive(true);
    }

    public void QuitCanvasBonus()
    {
        canvasBonus.SetActive(false);
        pauseButton.SetActive(true);
    }

    public void QuitCanvasBuyAction()
    {
        canvasBuyAction.SetActive(false);
    }

    public void Use()
    {
        if (my_ShopManager.actionBought >= 5)
        {
            my_ShopManager.actionBought -= 5;
            my_SM.currentStamina += 5;
            my_SM.ShowStamina();
            my_SM.CheckActualStamina();
            canvasDefeatStamina.SetActive(false);
            canvasBuyAction.SetActive(false);
            canvasBonus.SetActive(false);
            Time.timeScale = 1f;
            Debug.Log(my_ShopManager.actionBought);
        }

    }

    public void BuyStar()
    {
        my_ShopManager.actionBought += 5;
    }

    public void BuyMoreStar()
    {
        my_ShopManager.actionBought += 10;
    }
}
