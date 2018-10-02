using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pause : MonoBehaviour {

    public bool PauseActive = false;
    public GameObject PauseMenuUI;

    public string SceneToLoadQuit;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseActive)
            {
                ResumeButton();
            }
            else
            {
                MenuPause();
            }
            
        }
	}

    public void MenuPause()
    {
        PauseActive = true;
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ResumeButton()
    {
        PauseActive = false;
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void QuitButton()
    {
        SceneManager.LoadScene(SceneToLoadQuit);
    }
}
