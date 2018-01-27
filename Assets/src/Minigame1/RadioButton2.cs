using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioButton2 : MonoBehaviour,Interactable {

	public float Step;
	RadioVisualTuning RVT;
	// Use this for initialization
	void Start () {
		RVT = GetComponentInParent<RadioVisualTuning> ();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Mouse1() {
		if (RVT.Left ()) {
			gameObject.transform.Rotate (Vector3.right * Step, Space.Self);
		}

	}

	public void Mouse2() {
		if (RVT.Right ()) {
			gameObject.transform.Rotate (Vector3.left * Step, Space.Self);
		}
	}

}
