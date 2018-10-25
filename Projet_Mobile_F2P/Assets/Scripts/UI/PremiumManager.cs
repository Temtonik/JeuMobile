using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PremiumManager : MonoBehaviour {

    public static PremiumManager Singleton;

    public GameObject Button;
    public GameObject PremiumImg;
    bool premiumMod;
    GameObject Pub;

    private void Awake()
    {
        if (Singleton != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Singleton = this;
            DontDestroyOnLoad(this);
        }
    }

    // Use this for initialization
    void Start () {
        Pub = GameObject.FindGameObjectWithTag("Pub");
	}
	
	// Update is called once per frame
	void Update () {
        if (premiumMod)
        {
            Pub.SetActive(false);
        }
	}

    public void OnClickPremiumButton()
    {
        Destroy(Button);
        PremiumImg.SetActive(true);
        premiumMod = true;
    }
}
