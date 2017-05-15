using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

	private bool isPaused;

	// Use this for initialization
	void Start () {
		isPaused = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("esc") && !isPaused) {
			isPaused = true;
		}

		if (Input.GetKeyDown ("esc") && isPaused) {
			isPaused = false;
		}

		if (!isPaused) {
			Time.timeScale = 1;
		} 
		else if (isPaused) {
			Time.timeScale = 0;
		}
	}
}
