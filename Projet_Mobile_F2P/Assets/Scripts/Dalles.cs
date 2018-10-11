using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dalles : MonoBehaviour {

    public SwapMove my_SwapMove;

    public int activatedPress;
    public int numberPressInLevel;

    public GameObject triggerPress;
    public GameObject feedbackPress;
    public GameObject door;
    public GameObject triggerRaycast;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && my_SwapMove.is_Standing == true)
        {
            activatedPress += 1;
            triggerPress.SetActive(false);
            feedbackPress.SetActive(true);
            
            if (activatedPress == numberPressInLevel)
            {
                door.SetActive(false);
                triggerRaycast.SetActive(true);
            }
        }
    }


}
