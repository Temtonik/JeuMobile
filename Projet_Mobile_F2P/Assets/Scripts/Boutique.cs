using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boutique : MonoBehaviour {

    public GameObject boutiqueBonusCanvas;
    public GameObject boutiqueEurosCanvas;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void boutiqueEurosButton()
    {
        boutiqueBonusCanvas.SetActive(false);
        boutiqueEurosCanvas.SetActive(true);
    }

    public void boutiqueBonusButton()
    {
        boutiqueEurosCanvas.SetActive(false);
        boutiqueBonusCanvas.SetActive(true);
    }
}
