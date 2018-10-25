using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuto3 : MonoBehaviour {
    
    public GameObject TutoPiege;

    private AudioSource Audiosource;
    public AudioClip SndPiege;

    // Use this for initialization
    void Start () {
        Audiosource = GetComponent<AudioSource>();
        StartCoroutine(ShowTutoPiege());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator ShowTutoPiege()
    {
        yield return new WaitForSeconds(0.3f);
        TutoPiege.SetActive(true);
        PlayPiegeSound();
        StartCoroutine(HideTutoPiege());
    }

    IEnumerator HideTutoPiege()
    {
        yield return new WaitForSeconds(7f);
        TutoPiege.SetActive(false);
    }

    void PlayPiegeSound()
    {
        Audiosource.clip = SndPiege;
        Audiosource.Play();
    }
}
