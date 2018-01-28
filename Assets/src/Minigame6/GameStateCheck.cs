using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateCheck : MonoBehaviour {

	bool gameFinished = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		foreach (int i in UniversalState.MiniGameSolvedList) {
			if (i != 0)
				gameFinished = true;
		}

		if (gameFinished = true) 
				Application.Quit ();
	}
}
