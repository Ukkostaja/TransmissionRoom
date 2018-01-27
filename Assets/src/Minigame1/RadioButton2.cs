using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioButton2 : MonoBehaviour,Interactable {


	RadioVisualTuning RVT;
	// Use this for initialization
	void Start () {
		RVT = GetComponentInParent<RadioVisualTuning> ();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Mouse1() {
		RVT.Left ();
	}

	public void Mouse2() {
		RVT.Right ();
	}

}
