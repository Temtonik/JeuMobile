using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiegeActivation : MonoBehaviour {

    public GameObject electricTrapAnim;
    public StaminaManager my_StaminaManager;
    public int LoseStamina;
    public bool playerTriggered;
    public SoundManager my_SM;
    private DialogueManager myDM;


    // Use this for initialization
    void Start() {
        myDM = GameObject.FindGameObjectWithTag("DialogueManager").GetComponent<DialogueManager>();
    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !playerTriggered) 
        {
            myDM.PlayAieSound();
            playerTriggered = true;
            electricTrapAnim.SetActive(true);
            //my_SM.PlayTrapSound();
            my_StaminaManager.currentStamina -= LoseStamina;
            my_StaminaManager.ShowStamina();
            my_StaminaManager.CheckActualStamina();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerTriggered = false;
        }
    }
}
