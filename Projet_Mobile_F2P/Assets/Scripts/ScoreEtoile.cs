using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreEtoile : MonoBehaviour {

    public int nbAction;
    public int firstStar;
    public int secondStar;
    public int thirdStar;

    public bool ButtonIsPressed;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (ButtonIsPressed == true)
        {

            if (nbAction <= firstStar)
            {
                Debug.Log("You have 0 star !");
                ButtonIsPressed = false;
            }

            if (nbAction >= firstStar && nbAction < secondStar)
            {
                Debug.Log("You have 1 star !");
                ButtonIsPressed = false;
            }

            if (nbAction >= secondStar && nbAction < thirdStar)
            {
                Debug.Log("You have 2 stars !");
                ButtonIsPressed = false;
            }

            if (nbAction >= thirdStar)
            {
                Debug.Log("You have 3 stars !");
                ButtonIsPressed = false;
            }

            if (nbAction <= 0)
            {
                Debug.Log("You lose !");
                ButtonIsPressed = false;
            }
        }
    }

    public void OnClickAddAction()
    {
        ButtonIsPressed = true;
        nbAction -= 1;
    }
}
