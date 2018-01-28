using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bobber : MonoBehaviour {

	public float speed;
	public Vector3 goTo;
	Vector3 pore;
	Vector3 liikevektori;
	bool pactive;
	public bool PActive {
		get {
			return pactive;
		}
		set {
			this.pactive = value;
			Debug.Log("I have been set to:"+ value);

		}
	}


	public float catchDistance; 
	public FishSpawner fs;
	SpriteRenderer mySprite;
	public float bobbing;


	// Use this for initialization
	void Start () {
		mySprite = GetComponentInChildren<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (PActive) {
			Vector3 newPos = transform.position + (liikevektori * speed);
			transform.position = newPos;
			//Vector3 distance = transform.position - target;
			if (transform.position.y < 0f) {
				Debug.Log ("I have arrived");

				Decay[] targets = fs.GetComponentsInChildren<Decay> ();
				Vector3 pos;
				foreach (Decay cs in targets) {
					pos = cs.transform.position;
					float distance = Vector3.Distance (pos, transform.position);
					//Debug.Log ("distance:"+distance);
					if (distance < catchDistance) {
						int catchPicID = Random.Range (0, fs.catches.Length);
						mySprite.sprite = fs.catches [catchPicID];
						cs.Cauth ();

						
					}
				}
				//PActive = false;
			}

				
			if (transform.position.z < pore.z) {
				mySprite.sprite = null;
				//PActive = false;
			}
			
		}
	}


	void FloatAnim() {
		Vector3 newPos = transform.position;
		newPos.y = newPos.y + Random.value * bobbing;
	}


	public void Gogo(Vector3 pos) {
		goTo = pos;
		liikevektori = (pos-gameObject.transform.position)/600;
		Debug.Log ("Activate");
		PActive = true;
	}

	public void setPOR(Vector3 POS) {
		pore = POS;

	}

	public void Return() {
		Gogo (pore);
	}
}
