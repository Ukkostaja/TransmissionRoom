using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bobber : MonoBehaviour {

	public float speed;
	public Vector3 target;
	Vector3 pore;
	Vector3 liikevektori;
	public bool active;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (active) {

		}
	}


	void Gogo(Vector3 pos) {
		liikevektori = (pos-gameObject.transform.position)/1000;
	}

	public void setPOR(Vector3 POS) {
		pore = POS;
	}

	void Return() {
		Gogo (pore);
	}
}
