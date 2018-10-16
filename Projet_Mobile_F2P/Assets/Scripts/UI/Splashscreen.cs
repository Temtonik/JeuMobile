using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Splashscreen : MonoBehaviour {

    public GameObject title;
    public GameObject Main_Menu;
    public GameObject logo;

	// Use this for initialization
	void Start () {
        title.SetActive(false);
        Main_Menu.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            LogoAway();
        }
	}

    public void LogoAway()
    {
        title.SetActive(true);
        Main_Menu.SetActive(true);
        logo.SetActive(false);
    }
}
