using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour {

    public static int actionBought;
    public static int lifeBought;
    public static bool skin1;
    public static bool skin2;
    public static bool accessory;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Action()
    {
        actionBought += 5;
    }

    void MoreAction()
    {
        actionBought += 10;
    }

    void Life()
    {
        lifeBought += 1;
    }

    void Skin1()
    {
        skin1 == true;
    }

    void Skin2()
    {
        skin2 == true;
    }

    void Accessory()
    {
        accessory == true;
    }
}
