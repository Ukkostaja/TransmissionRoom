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
			if (bassstream != null) {
				bassstream.BASS_StreamFree (0);
				bassstream.BASS_Free ();
			}
			SceneManager.LoadScene (0);
		}
	}
}
