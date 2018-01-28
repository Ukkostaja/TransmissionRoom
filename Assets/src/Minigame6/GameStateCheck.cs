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
		if((UniversalState.MiniGame1Solved != 0) && (UniversalState.MiniGame2Solved != 0) && (UniversalState.MiniGame3Solved != 0) && 
			(UniversalState.MiniGame4Solved != 0) && (UniversalState.MiniGame5Solved != 0) && (UniversalState.MiniGame6Solved != 0)) 
			gameFinished = true;

		if (gameFinished = true) 
				Application.Quit ();
	}
}
