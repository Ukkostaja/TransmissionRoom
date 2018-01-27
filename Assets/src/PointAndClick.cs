using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndClick : MonoBehaviour {

	public bool fireOnce = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;

		if (fireOnce) {

			if (Input.GetButtonDown ("Fire1") || Input.GetButtonDown ("Fire2")) {
				Physics.Raycast (ray, out hit);
				//Debug.Log ("Hit");
				//if(hit != null) {
				Interactable kohde = hit.collider.gameObject.GetComponent<Interactable> ();
				//Debug.Log (kohde);
				if (kohde != null) {
					if (Input.GetButtonDown ("Fire1")) {
						kohde.Mouse1 ();
					}
					if (Input.GetButtonDown ("Fire2")) {
						kohde.Mouse2 ();
					}
				}
				//}

			}
		} else {
			//Copypastekoodia :(
			if (Input.GetButton ("Fire1") || Input.GetButton ("Fire2")) {
				Physics.Raycast (ray, out hit);
				//Debug.Log ("Hit");
				//if(hit != null) {
				Interactable kohde = hit.collider.gameObject.GetComponent<Interactable> ();
				//Debug.Log (kohde);
				if (kohde != null) {
					if (Input.GetButton ("Fire1")) {
						kohde.Mouse1 ();
					}
					if (Input.GetButton ("Fire2")) {
						kohde.Mouse2 ();
					}
				}
				//}

			}
		}








	}
}
