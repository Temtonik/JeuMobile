using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inPressChangeIdle : MonoBehaviour {

    //public bool animTriger = false;

    public Animator animator;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.anyKeyDown)
        {
            //animTriger = true;
            animator.SetBool("check", true);
        }
		
	}
}
