using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerStar : MonoBehaviour {

    public GameObject Star;
    public bool StarBonus = false;
    private SoundManager mySM;

    // Use this for initialization
    void Start ()
    {
        mySM = GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            mySM.PlayStarSound();
            Star.SetActive(false);
            StarBonus = true;
        }
    }
}
