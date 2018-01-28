using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioButton1 : MonoBehaviour,Interactable {


	public static float volume = 50f;
	public float visualStep = 2;
	public float volumeStep= 1;
//	public AudioSource radiovol;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void Mouse1() {
		if ((volume -= volumeStep) > 0f) {
			gameObject.transform.Rotate (Vector3.right * visualStep, Space.Self);
			bassstream.BASS_SetConfig (bassstream.configs.BASS_CONFIG_GVOL_STREAM, Mathf.RoundToInt (volume * 100.0f));
			RadioButton2.audio.volume = (volume / 100.0f);
//			Debug.Log (radiovol.volume);
		} else {
			volume = 0f;
		}
	}

	public void Mouse2() {
		//Debug.Log("volume oikealle");
		if ((volume += volumeStep) < 100f) {
			gameObject.transform.Rotate (Vector3.left * visualStep, Space.Self);
//			bassstream.BASS_SetVolume(volume/100.0f);
			bassstream.BASS_SetConfig (bassstream.configs.BASS_CONFIG_GVOL_STREAM, Mathf.RoundToInt (volume * 100.0f));
			RadioButton2.audio.volume = (volume / 100.0f);
//			Debug.Log (radiovol.volume);
		} else {
			volume = 100f;
		}

	}
}
