using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inPressChangeIdle : MonoBehaviour {


    public Animator animator;


	
	void Update () {

        if (Input.anyKeyDown)
        {
            animator.SetBool("check", true);
        }
		
	}
}
