using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

	public float MouseSpeed;
	public MyAudio soundii;

	// Use this for initialization
	void Start () {
		
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (soundii != null) {
			soundii.Play (1);
		}
	}


	// Update is called once per frame
	void Update () {
		Vector3 newPos = transform.position;
		newPos.y = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;
		transform.position = newPos;
	}
}
