using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kalasta : MonoBehaviour {
	Animator anim;
	public GameObject pointOfReturn;
	public Bobber koho;
	public GameObject rotationComp;
	bool canThrow= true;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		koho.transform.position = pointOfReturn.transform.position;
		koho.setPOR (pointOfReturn.transform.position);
	}


	public bool FishAnim() {
		float x = Quaternion.Angle (transform.rotation, rotationComp.transform.rotation);
		Debug.Log (x);
		if (x < 2f) {
			
			anim.CrossFade ("New Animation" ,1f);
			return true;
		}
		return false;
	}



	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1") && !koho.PActive && FishAnim()) { // kun painetaan jonnekin ja koho ei ole liikkeessä
											//animoidaan vapa
			Debug.Log(koho.PActive);
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			Physics.Raycast (ray, out hit); // etsitään osuttiinko veteen
			Vector3 targetPoint = hit.point;
			if (targetPoint != Vector3.zero) { //ollaan osuttu veteen
				if (canThrow) { 			//voidaan heittää
					if (targetPoint.z > 1) { // ei olla liian lähellä eli ei osuta laituriin
						koho.Gogo (targetPoint); //heitetään koho
						canThrow = false; // seuraavalla kerralla vedetään koho takaisin
					}
				} else { //jos ei voida heittää niin kelataan koho takaisin
					koho.Return ();
					canThrow = true;
				}
			}

			Debug.Log (targetPoint);
		}

	}
}
