using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_stop : MonoBehaviour {

    public GameObject StopLightInScene;
    public GameObject ActiveGyroLight;
    public GameObject ActiveLightRobot;

    private bool lightActive=true;
    public SwapMove my_Swipe;

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
        GestionLight();
	}

    public void GestionLight()
    {

        if (my_Swipe.is_Moving && lightActive)
        {
            StopLightInScene.SetActive(false);
            ActiveGyroLight.SetActive(true);
            StartCoroutine(ActiveLightForRobot());
            lightActive = false;
        }

    }

    IEnumerator ActiveLightForRobot()
    {
        yield return new WaitForSeconds(0.5f);
        ActiveLightRobot.SetActive(true);
        
    }
}
