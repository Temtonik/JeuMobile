using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuto2 : MonoBehaviour {

    public GameObject TutoLaser;

    private AudioSource Audiosource;
    public AudioClip SndLaser;

    // Use this for initialization
    void Start () {
		Audiosource = GetComponent<AudioSource>();
        StartCoroutine(ShowTutoLaser());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator ShowTutoLaser()
    {
        yield return new WaitForSeconds(0.3f);
        TutoLaser.SetActive(true);
        PlayLaserSound();
        StartCoroutine(HideTutoLaser());
    }

    IEnumerator HideTutoLaser()
    {
        yield return new WaitForSeconds(4.5f);
        TutoLaser.SetActive(false);
    }

    void PlayLaserSound()
    {
        Audiosource.clip = SndLaser;
        Audiosource.Play();
    }
}
