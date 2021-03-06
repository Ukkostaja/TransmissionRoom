﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour {

	public MyAudio soundii;
	public GameStart ball;
	public float MaxYDeltaPerStep=0.1f;

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
		Vector3 newPos = gameObject.transform.position;
		float currentY = newPos.y;
		float direction = ball.transform.position.y -currentY;
		float newY;
		if (direction >= 0) {
			newY= Mathf.Min (direction,
				             MaxYDeltaPerStep) +
			             newPos.y;
		} else {
			newY = Mathf.Max (direction,
				-MaxYDeltaPerStep)
				+ newPos.y;
							
		}
		newPos.y = newY;
		gameObject.transform.position = newPos;


	}
}
