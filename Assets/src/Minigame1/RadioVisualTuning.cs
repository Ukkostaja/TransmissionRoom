using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioVisualTuning : MonoBehaviour {

	public GameObject RadioNeedle;
	public GameObject LeftBound;
	public GameObject RightBound;
	public float StepLegnth = 0;


	// Use this for initialization
	void Start () {
		if(RadioNeedle == null || LeftBound == null || RightBound == null) Debug.Log("Not all GameObjects set in Editor");
	}

	public void Left() {
		if (RadioNeedle.transform.localPosition.z - StepLegnth < LeftBound.transform.localPosition.z) {
			Vector3 newPos= RadioNeedle.transform.localPosition;
			newPos.z -= StepLegnth;
			RadioNeedle.transform.localPosition = newPos;
			Tune ();
		}



	}


	public void Tune (){

	}


	public void Right() {
		if (RadioNeedle.transform.localPosition.z + StepLegnth > RightBound.transform.localPosition.z) {
			Vector3 newPos= RadioNeedle.transform.localPosition;
			newPos.z += StepLegnth;
			RadioNeedle.transform.localPosition = newPos;
			Tune ();
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
