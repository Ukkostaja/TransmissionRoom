using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

	public float MouseSpeed;

	// Use this for initialization
	void Start () {
		
	}



	// Update is called once per frame
	void Update () {
		Ray ray;
		Vector3 newPos = transform.position;
		newPos.y = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;
		transform.position = newPos;
	}
}
