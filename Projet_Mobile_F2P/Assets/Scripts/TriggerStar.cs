using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerStar : MonoBehaviour {

    public GameObject Star;
    public Image UiStar;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Star.SetActive(false);
            UiStar.fillAmount = 1;
        }
    }
}
