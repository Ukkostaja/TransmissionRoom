using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kalasta : MonoBehaviour {
	Animator anim;
	public GameObject pointOfReturn;
	Bobber koho;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		koho = GetComponentInChildren<Bobber> ();
		koho.transform.position = pointOfReturn.transform.position;
		koho.setPOR (pointOfReturn.transform.position);
	}


	public void Fish() {
		anim.CrossFade("New Animation",0.1f);
	}



	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			Fish ();

			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			Physics.Raycast (ray, out hit);
			Vector3 targetPoint = hit.point;
			if (targetPoint != Vector3.zero) {
				if (targetPoint.z > 1) {
					koho.gogo (targetPoint);
				}
			}

			Debug.Log (targetPoint);
		}

	}
}
