using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioButton1 : MonoBehaviour,Interactable {


	public float volume = 50f;
	public float visualStep = 2;
	public float volumeStep= 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void Mouse1() {
		if ((volume -= volumeStep) > 0f) {
			gameObject.transform.Rotate (Vector3.right * visualStep, Space.Self);
		} else {
			volume = 0f;
		}
	}

	public void Mouse2() {
		if ((volume += volumeStep) < 100f) {
			gameObject.transform.Rotate (Vector3.left * visualStep, Space.Self);
		} else {
			volume = 100f;
		}

	}
}
