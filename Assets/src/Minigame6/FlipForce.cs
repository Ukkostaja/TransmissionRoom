using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipForce : MonoBehaviour {

	public MyAudio soundii;

	// Use this for initialization
	void Start () {
	}

	void OnCollisionEnter2D(Collision2D coll) {
		soundii.Play (2);

	}


	// Update is called once per frame
	void Update () {
		
	}
}
