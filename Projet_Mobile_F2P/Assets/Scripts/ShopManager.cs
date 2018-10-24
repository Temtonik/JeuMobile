using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour {

    public static ShopManager Singleton;
    public int actionBought;
    public int lifeBought;
    public bool skin1;
    public bool skin2;
    public bool accessory;

    public static int nbStar;
    

    void Awake()
    {
        if (Singleton != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Singleton = this;
            DontDestroyOnLoad(this);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void Action()
    {
        actionBought += 5;
        nbStar-- ;
    }

    public void MoreAction()
    {
        actionBought += 10;
        nbStar -= 2;
    }

    public void Life()
    {
        lifeBought += 1;
        nbStar-- ;
    }

    public void Skin1()
    {
        skin1 = true;
        nbStar -= 17;
    }

    public void Skin2()
    {
        skin2 = true;
        nbStar -= 15;
    }

    public void Accessory()
    {
        accessory = true;
        nbStar -= 6;
    }

    public void Star()
    {
        nbStar += 5;
    }

    public void MoreStar()
    {
        nbStar += 10;
    }

    public void ALotOfStar()
    {
        nbStar += 20;
    }
}
