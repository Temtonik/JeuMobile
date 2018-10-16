using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dalles : MonoBehaviour {

    public SwapMove my_SwapMove;

    public int activatedPress;
    public int numberPressInLevel;

    public GameObject triggerPress;
    public GameObject feedbackPress;
    public GameObject[] door;
    public GameObject triggerRaycast;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay(Collider other)
    {
        Debug.Log("Je suis dans le trigger");
        if (other.gameObject.tag == "Player" && my_SwapMove.is_Standing)
        {
            Debug.Log("Je suis dans la fonction");
            activatedPress += 1;
            triggerPress.SetActive(false);
            feedbackPress.SetActive(true);

            DoorActive();
        }
    }

    void DoorActive()
    {
        if (activatedPress == numberPressInLevel)
        {
            for (int i = 0; i <= door.Length; i++)
            {
                door[i].SetActive(false);
                triggerRaycast.SetActive(true);
            }
        }
    }

}
