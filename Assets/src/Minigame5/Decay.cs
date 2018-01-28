using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decay : MonoBehaviour {

	public float decayTime=1;
	public float creationTime;


	// Use this for initialization
	void Start () {
		creationTime = Time.timeSinceLevelLoad;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad > creationTime + decayTime) {
			Destroy (gameObject);
		}
	}

	public void Cauth() {
		Destroy (gameObject);
	}
}
