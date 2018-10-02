using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroInput : MonoBehaviour {

    public GameObject RotationPoint;

	// Use this for initialization
	void Start () {
        Input.gyro.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 0, Input.gyro.rotationRateUnbiased.z);

        if (transform.rotation.z > 0)
        {
            RotationPoint.transform.Translate(Vector3.left * transform.rotation.z);
        }
        else if (transform.rotation.z < 0)
        {
            RotationPoint.transform.Translate(Vector3.left * transform.rotation.z);
        }
	}
}
