using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyInput : MonoBehaviour {
	bool notagain;


	// Use this for initialization
	void Start () {
		bool notagain = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.E && )) {


			SceneManager.LoadScene ("minigame2");
		}
	}
}
