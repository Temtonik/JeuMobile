﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_flicker : MonoBehaviour {

    Light testLight;
    public float minWaitTime;
    public float maxWaitTime;

    // Use this for initialization
    void Start () {
        testLight = GetComponent<Light>();
        StartCoroutine(Flashing());
    }

    IEnumerator Flashing()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minWaitTime, maxWaitTime));
            testLight.enabled = !testLight.enabled;

        }
    }
}
