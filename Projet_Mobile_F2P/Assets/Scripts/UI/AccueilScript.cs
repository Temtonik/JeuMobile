using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AccueilScript : MonoBehaviour {

    public string SceneToLoadPlay;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayButton ()
    {
        SceneManager.LoadScene(SceneToLoadPlay);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
