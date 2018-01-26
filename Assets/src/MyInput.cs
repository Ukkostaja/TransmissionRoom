using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyInput : MonoBehaviour {
	bool notagain;
	float delay;
	public float waittime; // in seconds;
	public SceneID[] activeObjects;


	// Use this for initialization
	void Start () {
		bool notagain = false;
		delay = Time.realtimeSinceStartup;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.E) && notagain == false) {
			notagain = true;
			delay = Time.realtimeSinceStartup;
			GameObject me = this.gameObject;
			SceneID winner = new SceneID (0);
			float winnerdistance = float.MaxValue;

			float distance = float.MaxValue;
			foreach (SceneID sid in activeObjects) {
				distance = Vector3.Distance (sid.gameObject.transform.position, this.gameObject.transform.position);
				if (distance < winnerdistance) {
					winnerdistance = distance;
					winner = sid;	
				}

			}

			Debug.Log (distance);

			if (distance < 3) {
				SceneManager.LoadScene (winner.id);
			}
		}

		if (Time.realtimeSinceStartup - delay > waittime) {
			notagain = false;
		}



	}
}
