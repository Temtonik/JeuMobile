using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour {

    public GameObject laserAnim;
    public GameObject canvasDefeat;
    public int actionBeforeLaserActive = 1;
    BoxCollider my_BC;
    private float startTimer = 0.2f;
    public float currentTimer;
    public SoundManager my_SM;
    public StaminaManager my_StaminaManager;

    public GameObject staminaBar;

    // Use this for initialization
    void Start () {

        //Au lancement de la scène la valeur est à 1
        actionBeforeLaserActive = 1;
        my_BC = GetComponent<BoxCollider>();
        currentTimer = startTimer * 60;
    }

// Update is called once per frame
void Update () {

        //Si valeur=0 le laser s'active sinon il se désactive
		if (actionBeforeLaserActive == 1)
        {
            laserAnim.SetActive(false);
            my_BC.isTrigger = false;
            currentTimer = startTimer * 60;
        }
        else if (actionBeforeLaserActive == 0)
        {
            //StartCoroutine(WaitForActive());
            //laserAnim.SetActive(true);
            //my_BC.isTrigger = true;
            currentTimer--;
            if(currentTimer == 0)
            {
                //my_SM.PlayLaserSound();
                laserAnim.SetActive(true);
                my_BC.isTrigger = true;
                currentTimer = 0;
            }
        }

        //Si la valeur est inférieur à -1 la mettre à 1
        if (actionBeforeLaserActive == -1)
        {
            actionBeforeLaserActive = 1;
        }
	}

    //En contact avec le laser le menu défaite s'affiche
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("I'm in the laser");
            StartCoroutine(WaitForKill());
        }
    }

    IEnumerator WaitForKill()
    {
        yield return new WaitForSeconds(0.3f);
        my_StaminaManager.currentStamina = -1;
        my_StaminaManager.ShowStamina();
        my_StaminaManager.CheckActualStamina();
        staminaBar.SetActive(false);
    }
}
