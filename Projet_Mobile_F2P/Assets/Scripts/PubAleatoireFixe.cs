using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PubAleatoireFixe : MonoBehaviour {

    public Image[] My_TabPub;
    public GameObject PanelPub;
    private AudioSource IGMusic;

	// Use this for initialization
	void Start ()
    {
        IGMusic = GameObject.FindGameObjectWithTag("IGMusic").GetComponent<AudioSource>();
        PanelPub.SetActive(true);
        ShowMyPub();
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void ShowMyPub ()
    {
        Time.timeScale = 0;
        for(int i=0; i<=My_TabPub.Length; i++)
        {
            var RandomPub = Random.Range(0, i);
            My_TabPub[RandomPub].fillAmount = 1;
        }
    }

    public void OnClickQuitPub ()
    {
        IGMusic.Play();
        PanelPub.SetActive(false);
        Time.timeScale = 1;
    }
}
