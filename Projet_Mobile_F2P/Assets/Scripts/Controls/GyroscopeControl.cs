using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroscopeControl : MonoBehaviour {

    public GameObject player;

    void Start()
    {
        Input.gyro.enabled = true;
    }

    void Update()
    {
        player.transform.Rotate(0, -Input.gyro.rotationRateUnbiased.y*5.0f * Time.timeScale, 0);
    }
}
