﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectControlMethod : MonoBehaviour {

	public PlayerMovement thePlayer;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		// DETECT MOUSE INPUT
		if (Input.GetMouseButton (0) || Input.GetMouseButton (1) || Input.GetMouseButton (2)) {

			thePlayer.useController = false;
		}

		if (Input.GetAxisRaw("Mouse X") != 0.0f || Input.GetAxisRaw("Mouse Y") != 0.0f){

			thePlayer.useController = false;
		}


		//DETECT CONTROLLER INPUT
		if (Input.GetAxisRaw ("RHorizontal") != 0.0f || Input.GetAxisRaw ("RVertical") != 0.0f) {
			thePlayer.useController = true;
		}

		if (Input.GetKey(KeyCode.JoystickButton0) || 
			Input.GetKey(KeyCode.JoystickButton1) || 
			Input.GetKey(KeyCode.JoystickButton2) || 
			Input.GetKey(KeyCode.JoystickButton3) || 
			Input.GetKey(KeyCode.JoystickButton4) || 
			Input.GetKey(KeyCode.JoystickButton5) || 
			Input.GetKey(KeyCode.JoystickButton6) || 
			Input.GetKey(KeyCode.JoystickButton7) || 
			Input.GetKey(KeyCode.JoystickButton8) || 
			Input.GetKey(KeyCode.JoystickButton9) || 
			Input.GetKey(KeyCode.JoystickButton10) || 
			Input.GetKey(KeyCode.JoystickButton11) || 
			Input.GetKey(KeyCode.JoystickButton12) || 
			Input.GetKey(KeyCode.JoystickButton13) || 
			Input.GetKey(KeyCode.JoystickButton14) || 
			Input.GetKey(KeyCode.JoystickButton15) || 
			Input.GetKey(KeyCode.JoystickButton16) || 
			Input.GetKey(KeyCode.JoystickButton17) || 
			Input.GetKey(KeyCode.JoystickButton18) || 
			Input.GetKey(KeyCode.JoystickButton19)){

			thePlayer.useController = true;
		}
	}
}
