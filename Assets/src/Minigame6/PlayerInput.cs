using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

	public float MouseSpeed;
	public MyAudio soundii;
	public AudioSource soundi;
	float lastScoreUpdate = 0;
	bool played = false;

	int playerScore;

	Scoring omascore;

	// Use this for initialization
	void Start () {
		omascore = GetComponentInChildren<Scoring> ();

	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (soundii != null) {
			soundii.Play (1);
		}
	}


	// Update is called once per frame
	void Update () {
		Vector3 newPos = transform.position;
		newPos.y = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;
		transform.position = newPos;


		if (Time.timeSinceLevelLoad > lastScoreUpdate + 1) {
			lastScoreUpdate = Time.timeSinceLevelLoad;
			UniversalState.MiniGame6Solved = int.Parse (omascore.scoreBoard.text);
			if (UniversalState.MiniGame6Solved != 0 && !played) {
				soundi.Play ();
				played = true;
			}
		}
	}
}
