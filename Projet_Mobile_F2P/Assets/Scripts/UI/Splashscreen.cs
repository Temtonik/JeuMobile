using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Splashscreen : MonoBehaviour {

    public GameObject title;
    public GameObject playButton;
    public GameObject shopButton;
    public GameObject logo;

	// Use this for initialization
	void Start () {
        title.SetActive(false);
        playButton.SetActive(false);
        shopButton.SetActive(false);
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
        playButton.SetActive(true);
        shopButton.SetActive(true);
        logo.SetActive(false);
    }
}
