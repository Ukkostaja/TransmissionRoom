using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bobber : MonoBehaviour {

	public float speed;
	public Vector3 target;
	Vector3 pore;
	Vector3 liikevektori;
	public bool active = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (active) {
			Vector3 newPos = transform.position + (liikevektori*speed);
			transform.position = newPos;
			Vector3 distance = transform.position - target;
			if (transform.position.y < 0)
				active = false;
			if( transform.position.z <pore.z) 
				active = false;
		}


	}


	public void Gogo(Vector3 pos) {
		liikevektori = (pos-gameObject.transform.position)/600;
		active = true;
	}

	public void setPOR(Vector3 POS) {
		pore = POS;
		active = true;
	}

	public void Return() {
		Gogo (pore);
	}
}
