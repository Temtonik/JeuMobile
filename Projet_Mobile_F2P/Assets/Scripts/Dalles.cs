using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dalles : MonoBehaviour {

    public SwapMove my_SwapMove;

    public static int activatedPress;
    public int numberPressInLevel;

    public Animator animator;

    public GameObject triggerPress;
    public GameObject[] door;
    public GameObject[] PassageCollidersDoor;

    public enum DalleFeedback { FirstDoor, SecondDoor, ThirdDoor, FourthDoor }
    public DalleFeedback dalleFeedbackSwitch;

    public GameObject anim1;
    public GameObject anim2;
    public GameObject anim3;
    public GameObject anim4;

    // Use this for initialization
    void Start () {
        activatedPress = 0;

        switch (dalleFeedbackSwitch)
        {
            case DalleFeedback.FirstDoor:
                anim1.SetActive(false);
                break;

            case DalleFeedback.SecondDoor:
                anim2.SetActive(false);
                break;

            case DalleFeedback.ThirdDoor:
                anim3.SetActive(false);
                break;

            case DalleFeedback.FourthDoor:
                anim4.SetActive(false);
                break;
        }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && my_SwapMove.is_Standing)
        {
            //animator.SetBool("button", true);
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
                    door[i].SetActive(false);
                    PassageCollidersDoor[i].SetActive(true);

            }
        }
    }

}
