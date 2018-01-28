using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackToHub : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.E)) {
			bassstream.BASS_StreamFree(0);
			bassstream.BASS_Free();
			GameObject me = this.gameObject;
			SceneID winner = this.GetComponent<SceneID>();
			SceneManager.LoadScene (winner.id);
		}
	}
}
