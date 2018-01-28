using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour {

	public MyAudio soundii;
	public Text scoreBoard;

	// Use this for initialization
	void Start () {
		
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.name.Contains ("Ball") && scoreBoard != null) {
			int i = int.Parse (scoreBoard.text);
			i++;
			scoreBoard.text = i.ToString();
			if (soundii != null) {
				soundii.Play (3);
			}
		}
	}


	// Update is called once per frame
	void Update () {
		
	}
}
