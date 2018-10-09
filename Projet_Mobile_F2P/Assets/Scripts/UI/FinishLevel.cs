using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour {

    public string nextLevel;

    public GameObject victoryCanvas;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            victoryCanvas.SetActive(true);
        }
    }

    public void GoToNextLevel()
    {
        SceneManager.LoadScene(nextLevel);
    }
}
