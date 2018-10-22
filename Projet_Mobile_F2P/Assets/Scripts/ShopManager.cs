using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour {

    public static int actionBought;
    public static int lifeBought;
    public static bool skin1;
    public static bool skin2;
    public static bool accessory;

    public int nbStar;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (skin1 == true)
        {
            skin2 = false;
        }
        if (skin2 == true)
        {
            skin1 = false;
        }
    }

    void Action()
    {
        actionBought += 5;
        nbStar-- ;
    }

    void MoreAction()
    {
        actionBought += 10;
        nbStar -= 2;
    }

    void Life()
    {
        lifeBought += 1;
        nbStar-- ;
    }

    void Skin1()
    {
        skin1 = true;
        nbStar -= 17;
    }

    void Skin2()
    {
        skin2 = true;
        nbStar -= 15;
    }

    void Accessory()
    {
        accessory = true;
        nbStar -= 6;
    }

    void Star()
    {
        nbStar += 5;
    }

    void MoreStar()
    {
        nbStar += 10;
    }

    void ALotOfStar()
    {
        nbStar += 20;
    }
}
