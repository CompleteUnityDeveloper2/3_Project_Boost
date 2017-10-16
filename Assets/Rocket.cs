using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        ProcessInput();
	}

    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space)) // can thrust while rotating
        {
            print("Thrusting");
        }

        if (Input.GetKey(KeyCode.A))
        {
            print("Rotating left");
        }
        else if (Input.GetKey(KeyCode.D))
        {
            print("Rotating right");
        }
    }
}