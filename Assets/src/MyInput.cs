using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyInput : MonoBehaviour {
	bool notagain;

	public SceneID[] activeObjects;


	// Use this for initialization
	void Start () {
		bool notagain = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.E) && notagain == false) {
			notagain = true;
			GameObject me = this.gameObject;
			SceneID winner = new SceneID(0);
			float winnerdistance = float.MaxValue;

			float distance;
			foreach (SceneID sid in activeObjects) {
				distance = Vector3.Distance(sid.gameObject.transform.position, this.gameObject.transform.position);
				if (distance < winnerdistance) {
					winnerdistance = distance;
					winner = sid;	
				}

			}




			SceneManager.LoadScene(winner.id);
		}



	}
}
