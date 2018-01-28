using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puzzle2Trigger : MonoBehaviour {
	GameObject[] allChildTriggers;
	public AudioSource soundi;
	int triggered = 0;
	int boxesToBeTossed = 30;
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
			//play sound
			soundi.Play();
			bassstream.BASS_StreamFree (0);
			bassstream.BASS_Free ();
			SceneManager.LoadScene (1);
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
			if (triggered == 7 || boxesToBeTossed >= 10) return true;
			else return false;
	}
}