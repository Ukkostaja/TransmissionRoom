using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioButton1 : MonoBehaviour,Interactable {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void Mouse1() {
		Debug.Log("Ping");
	}

	public void Mouse2() {
		Debug.Log("Pong");
	}
}
