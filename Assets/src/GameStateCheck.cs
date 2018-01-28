using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateCheck : MonoBehaviour {

	bool gameFinished = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if ((UniversalState.MiniGame1Solved != 0) && (UniversalState.MiniGame2Solved != 0) && (UniversalState.MiniGame3Solved != 0) &&
		    (UniversalState.MiniGame5Solved != 0) && (UniversalState.MiniGame6Solved != 0))
			gameFinished = true;
		else
			gameFinished = false;

		if (gameFinished == true) {
			//play sound, goto end screen
			bassstream.BASS_StreamFree (0);
			bassstream.BASS_Free ();
			SceneManager.LoadScene (8);
		}
		if (Input.GetKey (KeyCode.Escape))
			Application.Quit ();
	}
}
