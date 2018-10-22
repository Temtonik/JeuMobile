using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IGActionShop : ShopManager {

    public GameObject canvasBonus;
    public GameObject canvasBuyAction;



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
        ShopManager.actionBought -= 5;
        Debug.Log(actionBought);
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
