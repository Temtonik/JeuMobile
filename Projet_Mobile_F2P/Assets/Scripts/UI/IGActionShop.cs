using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IGActionShop : MonoBehaviour {

    public GameObject canvasBonus;
    public GameObject canvasBuyAction;
    public GameObject canvasDefeatStamina;
    public GameObject pauseButton;
    public GameObject canvasBoutique;

    public StaminaManager my_SM;

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
        canvasBoutique.SetActive(true);
    }

    public void CanvasBuyAction()
    {
        canvasBuyAction.SetActive(true);
    }

    public void QuitCanvasBonus()
    {
        canvasBonus.SetActive(false);
        pauseButton.SetActive(true);
        canvasBoutique.SetActive(false);
    }

    public void QuitCanvasBuyAction()
    {
        canvasBuyAction.SetActive(false);
    }

    public void Use()
    {
        if (ShopManager.Singleton.actionBought >= 5)
        {
            ShopManager.Singleton.actionBought -= 5;
            my_SM.currentStamina += 5;
            my_SM.ShowStamina();
            my_SM.CheckActualStamina();
            canvasDefeatStamina.SetActive(false);
            canvasBuyAction.SetActive(false);
            canvasBonus.SetActive(false);
            canvasBoutique.SetActive(false);
            pauseButton.SetActive(true);
            Time.timeScale = 1f;
        }

    }

    public void BuyStar()
    {
        ShopManager.Singleton.actionBought += 5;
    }

    public void BuyMoreStar()
    {
        ShopManager.Singleton.actionBought += 10;
    }
}
