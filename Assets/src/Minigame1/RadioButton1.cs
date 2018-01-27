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
		gameObject.transform.Rotate (Vector3.left, Space.Self);
		Debug.Log("Ping");
	}

	public void Mouse2() {
		gameObject.transform.Rotate (Vector3.right, Space.Self);
		Debug.Log("Pong");
	}
}
