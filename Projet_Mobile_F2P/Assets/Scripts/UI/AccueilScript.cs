using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AccueilScript : MonoBehaviour {

    public string SceneToLoad;
    public string SceneToLoad2;
    public string SceneToLoad3;
    public string SceneToLoad4;
    public string Return;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ButtonOne()
    {
        SceneManager.LoadScene(SceneToLoad);
    }

    public void ButtonTwo()
    {
        SceneManager.LoadScene(SceneToLoad2);
    }

    public void ButtonThree()
    {
        SceneManager.LoadScene(SceneToLoad3);
    }

    public void ButtonFour()
    {
        SceneManager.LoadScene(SceneToLoad4);
    }

    public void ReturnButton()
    {
        SceneManager.LoadScene(Return);
    }
}
