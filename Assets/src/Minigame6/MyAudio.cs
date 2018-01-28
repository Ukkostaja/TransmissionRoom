using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAudio : MonoBehaviour {

	AudioSource soundii;
	public AudioClip[] clipit;
	// Use this for initialization
	void Start () {
		soundii = GetComponent<AudioSource> ();
	}

	public void Play(int id) {
		if (id <= 0 || id > clipit.Length) {
			
		} else {
			soundii.clip = clipit [id-1];
			soundii.Play();
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
