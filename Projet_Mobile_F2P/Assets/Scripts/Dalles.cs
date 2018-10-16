using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dalles : MonoBehaviour {

    public SwapMove my_SwapMove;

    public static int activatedPress;
    public int numberPressInLevel;

    public GameObject triggerPress;
    //public GameObject feedbackPress;

    public GameObject[] door;
    public GameObject[] PassageCollidersDoor;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && my_SwapMove.is_Standing)
        {
            activatedPress += 1;
            triggerPress.SetActive(false);
            //feedbackPress.SetActive(true);

            DoorActive();
        }
    }

    void DoorActive()
    {
        if (activatedPress == numberPressInLevel)
        {
            for (int i = 0; i <= door.Length; i++)
            {
                for (int j = 0; j <= PassageCollidersDoor.Length; j++)
                {
                    door[i].SetActive(false);
                    PassageCollidersDoor[j].SetActive(true);
                }
            }
        }
    }

}
