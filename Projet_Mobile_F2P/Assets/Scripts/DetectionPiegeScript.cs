using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionPiegeScript : MonoBehaviour {

    public GameObject detectPiegeUI;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            detectPiegeUI.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            detectPiegeUI.SetActive(false);
        }
    }
}
