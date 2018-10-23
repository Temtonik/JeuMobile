using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IGActionShop : ShopManager {

    public GameObject canvasBonus;
    public GameObject canvasBuyAction;
    public GameObject canvasDefeatStamina;

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
    }

    public void CanvasBuyAction()
    {
        canvasBuyAction.SetActive(true);
    }

    public void QuitCanvasBonus()
    {
        canvasBonus.SetActive(false);
    }

    public void QuitCanvasBuyAction()
    {
        canvasBuyAction.SetActive(false);
    }

    public void Use()
    {
        if (ShopManager.actionBought >= 5)
        {
            ShopManager.actionBought -= 5;
            my_SM.currentStamina += 5;
            canvasDefeatStamina.SetActive(false);
            canvasBuyAction.SetActive(false);
            canvasBonus.SetActive(false);
            Time.timeScale = 1f;
        }

    }

    public void BuyStar()
    {
        ShopManager.actionBought += 5;
    }

    public void BuyMoreStar()
    {
        ShopManager.actionBought += 10;
    }
}
