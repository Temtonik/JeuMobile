﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchatScript : MonoBehaviour {

    public enum ShopActions { FiveActions, TenActions, Life, UseActions }
    public ShopActions contextualShopActions;
    public IGActionShop ShopInGame;

    // Use this for initialization
    void Start () {
        switch (contextualShopActions)
        {
            case ShopActions.FiveActions:
                GetComponent<Button>().onClick.AddListener(() => ShopManager.Singleton.Action());
                break;

            case ShopActions.TenActions:
                GetComponent<Button>().onClick.AddListener(() => ShopManager.Singleton.MoreAction());
                break;

            case ShopActions.Life:
                GetComponent<Button>().onClick.AddListener(() => ShopManager.Singleton.Life());
                break;

            case ShopActions.UseActions:
                GetComponent<Button>().onClick.AddListener(() => ShopInGame.Use());
                break;
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
