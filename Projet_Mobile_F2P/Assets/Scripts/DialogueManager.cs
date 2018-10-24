using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour {

    private AudioSource AudioSource;

    public AudioClip Snd_Aie;
    public AudioClip Snd_Batterie;
    public AudioClip Snd_Boulons;
    public AudioClip Snd_Detruire;

    // Use this for initialization
    void Start () {
        AudioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayAieSound()
    {
        AudioSource.clip = Snd_Aie;
        AudioSource.Play();
    }
    public void PlayBatterieSound()
    {
        AudioSource.clip = Snd_Batterie;
        AudioSource.Play();
    }
    public void PlayBoulonSound()
    {
        AudioSource.clip = Snd_Boulons;
        AudioSource.Play();
    }
    public void PlayDetruireSound()
    {
        AudioSource.clip = Snd_Detruire;
        AudioSource.Play();
    }
}
