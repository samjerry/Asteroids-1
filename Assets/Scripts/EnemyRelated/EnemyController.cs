using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
	
	private Rigidbody myRB;
	public float moveSpeed;

	private PlayerMovement thePlayer;

	// Use this for initialization
	void Start () {
		thePlayer = GameObject.Find("Player").GetComponent<PlayerMovement>();
		myRB = GetComponent<Rigidbody>();
		thePlayer = FindObjectOfType<PlayerMovement> ();
	}


	void FixedUpdate(){
		//STATIC MOVEMENT REPLACE THIS WITH PATHBAKING!!!!!
		//myRB.velocity = transform.forward * moveSpeed;
	}

	// Update is called once per frame
	//void Update () {
		//transform.LookAt (thePlayer.transform.position);
	//}
}
