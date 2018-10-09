using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapMove : MonoBehaviour {

    public GameObject Player;
    private Vector3 fp;   //First touch position
    private Vector3 lp;   //Last touch position
    private float dragDistance;  //minimum distance for a swipe to be registered
    public float rayDistance = 10f;

    // Use this for initialization
    void Start ()
    {
        dragDistance = Screen.height * 15 / 100; //dragDistance is 15% height of the screen
    }

    // Update is called once per frame
    void Update()
    {
        //Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

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

                if (Mathf.Abs(lp.x - fp.x) > dragDistance || Mathf.Abs(lp.y - fp.y) > dragDistance)
                {
                    if (lp.y > fp.y)  //If the movement was up
                    {
                        //RaycastHit hit;
                        //if (Physics.Raycast(ray, out hit, 10f))
                        //{
                            //if (!hit.collider.CompareTag("Wall"))
                            //{
                                Debug.Log("Move");
 
                                if (Player.transform.rotation.eulerAngles.y >= 0 && Player.transform.rotation.eulerAngles.y <= 30 || Player.transform.rotation.eulerAngles.y >= 330 && Player.transform.rotation.eulerAngles.y <= 360)
                                {
                                    Debug.Log("Angle1");
                                    Player.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z + 3.0f);
                                }
                                else if (Player.transform.rotation.eulerAngles.y >= 60 && Player.transform.rotation.eulerAngles.y <= 110)
                                {
                                    Debug.Log("Angle2");
                                    Player.transform.position = new Vector3(Player.transform.position.x + 3.0f, Player.transform.position.y, Player.transform.position.z);
                                }
                                else if (Player.transform.rotation.eulerAngles.y >= 150 && Player.transform.rotation.eulerAngles.y <= 210)
                                {
                                    Debug.Log("Angle3");
                                    Player.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z - 3.0f);
                                }
                                else if (Player.transform.rotation.eulerAngles.y >= 240 && Player.transform.rotation.eulerAngles.y <= 300)
                                {
                                    Debug.Log("Angle4");
                                    Player.transform.position = new Vector3(Player.transform.position.x - 3.0f, Player.transform.position.y, Player.transform.position.z);
                                }
                            //}
                        //}
                    }
                    else
                    {   //Down swipe
                        Debug.Log("Don't Move");
                    }
                }
                else
                {   //It's a tap as the drag distance is less than 20% of the screen height
                    Debug.Log("Tap");
                }
            }
        }
    }
}
