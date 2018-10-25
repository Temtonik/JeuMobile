using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnexionManager : MonoBehaviour {

    public GameObject StarImg;
    public GameObject Button;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClickButtonConnexion()
    {
        Destroy(Button);
        StarImg.SetActive(true);
        ShopManager.Singleton.nbStar++;
    }
}
