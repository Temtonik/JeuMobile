using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public static SoundManager Singleton;

    private AudioSource AudioSource;

    public AudioClip Snd_Swipe;
    public AudioClip Snd_Stay;
    public AudioClip Snd_Die;
    public AudioClip Snd_Laser;
    public AudioClip Snd_Trap;

    // Use this for initialization
    void Start () {
        AudioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlaySwipeSound()
    {
        AudioSource.loop = false;
        AudioSource.clip = Snd_Swipe;
        AudioSource.Play();
    }
    public void PlayStaySound()
    {
        AudioSource.loop = false;
        AudioSource.clip = Snd_Stay;
        AudioSource.Play();
    }

    public void PlayDieSound()
    {
        AudioSource.loop = false;
        AudioSource.clip = Snd_Die;
        AudioSource.Play();
    }

    public void PlayLaserSound()
    {
        AudioSource.clip = Snd_Laser;
        AudioSource.Play();
        AudioSource.loop = true;
    }

    public void PlayTrapSound()
    {
        AudioSource.clip = Snd_Trap;
        AudioSource.Play();
        AudioSource.loop = true;
    }
}
