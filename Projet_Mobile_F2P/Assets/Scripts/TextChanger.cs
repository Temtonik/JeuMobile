using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour {

    public Text actionsBoughtText;
    public Text starNumberText;
    public Text lifeNumberText;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (actionsBoughtText != null)
        {
            actionsBoughtText.text = "" + ShopManager.Singleton.actionBought;
        }
        if (lifeNumberText != null)
        {
            lifeNumberText.text = "" + ShopManager.Singleton.lifeBought;
        }
        starNumberText.text = "" + ShopManager.Singleton.nbStar;
    }
}
