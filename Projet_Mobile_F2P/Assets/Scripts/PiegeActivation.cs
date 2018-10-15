using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiegeActivation : MonoBehaviour {

    //public GameObject electricTrapAnim;
    public StaminaManager my_StaminaManager;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            //electricTrapAnim.SetActive(true);
            my_StaminaManager.currentStamina -= 3;
            my_StaminaManager.ShowStamina();
            my_StaminaManager.CheckActualStamina();
        }
    }
}
