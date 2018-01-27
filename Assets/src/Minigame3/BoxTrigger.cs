﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTrigger : MonoBehaviour {

	int objectsTriggered = 0;

	// This property is utilized by the scene in order to see if the puzzle has been resolved.
	bool threeObjectsTriggered = false;
	public bool ThreeObjectsTriggered{
		get { return threeObjectsTriggered; }
		set { threeObjectsTriggered = value; }
	}

	// Use this for initialization
	void Start () {
	}

	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "CubeBoxCube") objectsTriggered++;

		if (IsThreeObjectsTriggered ()) {
			UniversalState.MiniGame3Solved = 1;
		}
	}

	bool IsThreeObjectsTriggered(){
		if (objectsTriggered > 2)
			return true;
		else
			return false;
	}
}
