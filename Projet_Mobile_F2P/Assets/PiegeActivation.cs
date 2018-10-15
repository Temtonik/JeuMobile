using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiegeActivation : MonoBehaviour {

    public GameObject electricTrapAnim;

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
            //stamina -3;
            electricTrapAnim.SetActive(true);
            
        }
    }
}
