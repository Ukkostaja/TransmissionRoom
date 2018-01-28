using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour {

	Rigidbody2D body;
	Vector2 startLoc;
	public float speed = 0.1f;
	public GameObject Home;

	// Use this for initialization
	void Start () {
		
		startLoc = transform.position;
		body = GetComponent<Rigidbody2D> ();
		Respawn();
	}
	
	// Update is called once per frame
	void Update () {
		if (Home != null) {
			if (Vector3.Distance (gameObject.transform.position, Home.transform.position) > 20f) {
				SceneManager.LoadScene (0);
			
			}
		}
	}


	public void Respawn() {
		body.velocity =  new Vector2 (speed, speed);
	}

}
