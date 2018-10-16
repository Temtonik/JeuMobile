using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AccueilScript : MonoBehaviour {

    public GameObject selectLevelCanvas;
    public GameObject shopCanvas;
    public GameObject homeCanvas;

    public string Level1;
    public string Level2;
    public string Level3;
    public string Level4;
    public string Return;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayButton()
    {
        selectLevelCanvas.SetActive(true);
        homeCanvas.SetActive(false);
    }

    public void ShopButton()
    {
        shopCanvas.SetActive(true);
    }



     public void LevelOne()
     {
         SceneManager.LoadScene(Level1);
     }

     public void LevelTwo()
     {
         SceneManager.LoadScene(Level2);
     }

     public void LevelThree()
     {
         SceneManager.LoadScene(Level3);
     }

         public void LevelFour()
     {
         SceneManager.LoadScene(Level4);
     }

     public void ReturnButton()
     {
        selectLevelCanvas.SetActive(false);
        homeCanvas.SetActive(true);
     }

    public void ParrainageButton()
    {
        SceneManager.LoadScene("Parrainage");
    }
}
