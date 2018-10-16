using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapMove : MonoBehaviour
{

    public GameObject Player;

    private Vector3 fp;   //First touch position
    private Vector3 lp;   //Last touch position
    private Vector3 newPos = new Vector3();

    private float dragDistance;  //minimum distance for a swipe to be registered
    public float rayDistance;
    public float MoveSpeed;
    public float MoveValue;

    public bool is_Moving, is_Standing, is_acting;
    private bool inMovement = false;
    private bool UseStamina = false;

    public SoundManager my_SM;
    public StaminaManager my_StaminaManager;


    // Use this for initialization
    void Start()
    {
        dragDistance = Screen.height * 15 / 100; //dragDistance is 15% height of the screen
    }

    // Update is called once per frame
    void Update()
    {
        MoveSwapDown();
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, rayDistance) && !inMovement)
        {
            MoveSwapUp();
        }
        else if (inMovement)
        {
            Player.transform.position = Vector3.MoveTowards(Player.transform.position, newPos, MoveSpeed * Time.deltaTime);
            if (Player.transform.position == newPos)
            {
                inMovement = false;
            }
        }
        if (UseStamina == true && is_acting == true)
        {
            my_StaminaManager.UpdateStamina();
            UseStamina = false;
            is_acting = false;
        }
    }

    public void MoveSwapUp()
    {
        if (Input.touchCount == 1) // user is touching the screen with a single touch
        {
            Touch touch = Input.GetTouch(0); // get the touch
            if (touch.phase == TouchPhase.Began) //check for the first touch
            {
                fp = touch.position;
                lp = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved) // update the last position based on where they moved
            {
                lp = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended) //check if the finger is removed from the screen
            {
                lp = touch.position;  //last touch position.
            }

            if (Mathf.Abs(lp.x - fp.x) > dragDistance || Mathf.Abs(lp.y - fp.y) > dragDistance)
            {
                if (lp.y > fp.y)  //If the movement was up
                {
                    Debug.Log("Move");
                    is_Moving = true;
                    is_acting = true;
                    my_SM.PlaySwipeSound();

                    if (Player.transform.rotation.eulerAngles.y >= 0 && Player.transform.rotation.eulerAngles.y <= 30 || Player.transform.rotation.eulerAngles.y >= 330 && Player.transform.rotation.eulerAngles.y <= 360)
                    {
                        Debug.Log("Angle1");
                        newPos = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z + MoveValue);
                    }
                    else if (Player.transform.rotation.eulerAngles.y >= 60 && Player.transform.rotation.eulerAngles.y <= 110)
                    {
                        Debug.Log("Angle2");
                        newPos = new Vector3(Player.transform.position.x + MoveValue, Player.transform.position.y, Player.transform.position.z);
                    }
                    else if (Player.transform.rotation.eulerAngles.y >= 150 && Player.transform.rotation.eulerAngles.y <= 210)
                    {
                        Debug.Log("Angle3");
                        newPos = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z - MoveValue);
                    }
                    else if (Player.transform.rotation.eulerAngles.y >= 240 && Player.transform.rotation.eulerAngles.y <= 300)
                    {
                        Debug.Log("Angle4");
                        newPos = new Vector3(Player.transform.position.x - MoveValue, Player.transform.position.y, Player.transform.position.z);
                    }

                    inMovement = true;

                }
            }
        }

    }

    public void MoveSwapDown()
    {
        if (Input.touchCount == 1) // user is touching the screen with a single touch
        {
            Touch touch = Input.GetTouch(0); // get the touch
            if (touch.phase == TouchPhase.Began) //check for the first touch
            {
                fp = touch.position;
                lp = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved) // update the last position based on where they moved
            {
                lp = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended) //check if the finger is removed from the screen
            {
                lp = touch.position;  //last touch position.
                UseStamina = true;
            }

            if (Mathf.Abs(lp.x - fp.x) > dragDistance || Mathf.Abs(lp.y - fp.y) > dragDistance)
            {
                if (lp.y < fp.y && !is_Standing)  //If the movement was Down
                {
                    Debug.Log("Don't Move");
                    is_Standing = true;
                    is_acting = true;
                    my_SM.PlayStaySound();
                }
            }
        }
    }
}
