﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioButton2 : MonoBehaviour,Interactable {

	public float Step;
	RadioVisualTuning RVT;
	public static AudioSource audio;
	public static bool touched;

	// Use this for initialization
	void Start () {
		RVT = GetComponentInParent<RadioVisualTuning> ();
		audio = GetComponent<AudioSource>();
		touched = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (touched && (Input.GetButtonUp ("Fire1") || Input.GetButtonUp ("Fire2"))) {
			//lopeta kohina

			bassstream.Play ();
			bassstream.BASS_SetConfig (bassstream.configs.BASS_CONFIG_GVOL_STREAM, Mathf.RoundToInt (RadioButton1.volume * 100.0f));
			touched = false;
		}
	}

	public void Mouse2() {
			if (RVT.Right ()) {
				gameObject.transform.Rotate (Vector3.left * Step, Space.Self);
				touched = true;
			}
			if (touched && (Input.GetButtonDown ("Fire1") || Input.GetButtonDown ("Fire2"))) {
				if (!audio.isPlaying) {
					Debug.Log ("Kohise");
					audio.Play();
					touched = false;
				}
			}
		}

	public void Mouse1() {
		if (RVT.Left ()) {
			gameObject.transform.Rotate (Vector3.right * Step, Space.Self);
			touched = true;
		}
		if (touched && (Input.GetButtonDown ("Fire1") || Input.GetButtonDown ("Fire2"))) {
			if (!audio.isPlaying) {
				Debug.Log ("Kohise");
				audio.Play();
				touched = false;
			}
		}
	}

}
