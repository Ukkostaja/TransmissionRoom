using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kalasta : MonoBehaviour {
	Animator anim;
	public GameObject pointOfReturn;
	public Bobber koho;
	bool canThrow= true;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		koho.transform.position = pointOfReturn.transform.position;
		koho.setPOR (pointOfReturn.transform.position);
	}


	public void FishAnim() {
		anim.CrossFade("New Animation",0.1f);
	}



	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1") && !koho.Active) { // kun painetaan jonnekin ja koho ei ole liikkeessä
			FishAnim ();											//animoidaan vapa
			Debug.Log(koho.Active);
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
