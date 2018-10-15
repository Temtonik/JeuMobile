using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour {

    public GameObject laserAnim;
    public GameObject canvasDefeat;
    public int actionBeforeLaserActive = 1;

	// Use this for initialization
	void Start () {

        //Au lancement de la scène la valeur est à 1
        actionBeforeLaserActive = 1;
    }

// Update is called once per frame
void Update () {

        //Si valeur=0 le laser s'active sinon il se désactive
		if (actionBeforeLaserActive == 0)
        {
            laserAnim.SetActive(true);
        }
        else
        {
            laserAnim.SetActive(false);
        }

        //Si la valeur est inférieur à -1 la mettre à 1
        if (actionBeforeLaserActive == -1)
        {
            actionBeforeLaserActive = 1;
        }
	}

    //En contact avec le laser le menu défaite s'affiche
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canvasDefeat.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
