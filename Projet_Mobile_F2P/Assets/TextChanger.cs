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
        actionsBoughtText.text = "" + ShopManager.Singleton.actionBought;
        starNumberText.text = "" + ShopManager.Singleton.nbStar;
        lifeNumberText.text = "" + ShopManager.Singleton.lifeBought;
    }
}
