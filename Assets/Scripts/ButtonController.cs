using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonController : MonoBehaviour {

	// Use this for initialization
	public void LoadLevel(int scene){
		SceneManager.LoadScene(scene);
	}
	
	// Update is called once per frame
	public void QuitButton () {
		Application.Quit();
	}
}
