﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2Trigger : MonoBehaviour {
	GameObject[] allChildTriggers;
	int triggered = 0;
	int boxesToBeTossed = 7;
	// Use this for initialization
	void Start () {
		allChildTriggers = GameObject.FindGameObjectsWithTag ("Puzzle2Trigger");
		Debug.Log ("jäljellä " + boxesToBeTossed);
	}
	
	// Update is called once per frame
	void Update () {
		if (IsConditionsMet ()) {
			Debug.Log("läpi") ;
			UniversalState.MiniGame2Solved = 1;
		}
	}

	// boxit
	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Puzzle2Block" || boxesToBeTossed != 0)
			boxesToBeTossed--;
		Debug.Log ("jäljellä " + boxesToBeTossed);
		
	}

	void OnTriggerStay(Collider col){
	
	}

	void OnTriggerExit(Collider col){
		if (col.gameObject.tag == "Puzzle2Block")
			boxesToBeTossed++;
		Debug.Log ("jäljellä " + boxesToBeTossed);
	}

	void CheckTossedBoxes(){
		foreach (GameObject go in allChildTriggers) {
			if (go.GetComponentInChildren<ChildTrigger> ().IsMirrorOnPlace)
				triggered++;
			Debug.Log (triggered);
		}
	}

	bool IsConditionsMet() {
			if (triggered == 7 || boxesToBeTossed == -10) return true;
			else return false;
	}
}