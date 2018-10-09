using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keyboardontouch : MonoBehaviour {

    TouchScreenKeyboard keyboard;

    public void OpenKeyboard () {
        keyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.EmailAddress);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
