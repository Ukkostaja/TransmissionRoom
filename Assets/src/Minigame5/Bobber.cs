using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bobber : MonoBehaviour {

	public float speed;
	public Vector3 target;
	Vector3 pore;
	Vector3 liikevektori;
	bool active;
	public bool Active {
		get {
			return active;
		}
		set {
			this.active = value;
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
		if (Active) {
			Vector3 newPos = transform.position + (liikevektori * speed);
			transform.position = newPos;
			//Vector3 distance = transform.position - target;
			if (transform.position.y < 0) {
				Decay[] targets = fs.GetComponentsInChildren<Decay> ();
				Vector3 pos;
				foreach (Decay cs in targets) {
					pos = cs.transform.position;
					float distance = Vector3.Distance (pos, transform.position);
					Debug.Log ("distance:"+distance);
					if (distance < catchDistance) {
						int catchPicID = Random.Range (0, fs.catches.Length);
						mySprite.sprite = fs.catches [catchPicID];
						cs.Cauth ();

						
					}
				}
				Active = false;
			}

				
			if (transform.position.z < pore.z) {
				mySprite.sprite = null;
				Active = false;
			}
			
		}
	}


	void FloatAnim() {
		Vector3 newPos = transform.position;
		newPos.y = newPos.y + Random.value * bobbing;
	}


	public void Gogo(Vector3 pos) {
		target = pos;
		liikevektori = (pos-gameObject.transform.position)/600;
		Debug.Log ("Activate");
		Active = true;
	}

	public void setPOR(Vector3 POS) {
		pore = POS;

	}

	public void Return() {
		Gogo (pore);
	}
}
