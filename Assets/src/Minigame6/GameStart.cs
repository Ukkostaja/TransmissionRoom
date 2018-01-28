using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour {

	Rigidbody2D body;
	Vector2 startLoc;
	public float speed = 0.1f;

	// Use this for initialization
	void Start () {
		
		startLoc = transform.position;
		body = GetComponent<Rigidbody2D> ();
		Respawn();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void Respawn() {
		body.velocity =  new Vector2 (speed, speed);
	}

}
