using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour {

    public string nextLevel;
    public Animator animator;

    public GameObject victoryCanvas;
    public GameObject pauseButton;
    public GameObject staminaBar;
    public GameObject canvasBoutique;
    public SoundManager mySM;

    // Use this for initialization
    void Start () {
        mySM = GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //animator.SetBool("victory", true);
            mySM.PlayVictorySound();
            victoryCanvas.SetActive(true);
            Destroy(pauseButton);
            staminaBar.SetActive(false);
            canvasBoutique.SetActive(false);
            Time.timeScale = 0f;
        }
    }

    public void GoToNextLevel()
    {
        SceneManager.LoadScene(nextLevel);
        Time.timeScale = 1f;
    }


    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

        public void QuitButton()
    {
        SceneManager.LoadScene("Accueil");
        Time.timeScale = 1f;
    }
}
