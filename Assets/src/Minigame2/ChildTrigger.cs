using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildTrigger : MonoBehaviour {

	bool isMirrorOnPlace;
	public bool IsMirrorOnPlace {
		get { return isMirrorOnPlace; }
		set { isMirrorOnPlace = value; }
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
		if ((name.Contains ("NW") && col.gameObject.name.Contains ("NW")) ||
		    (name.Contains ("SW") && col.gameObject.name.Contains ("SW")) ||
		    (name.Contains ("NE") && col.gameObject.name.Contains ("NE")) ||
		    (name.Contains ("SE") && col.gameObject.name.Contains ("SE")))
			isMirrorOnPlace = true; 
	}

	void OnTriggerExit(Collider col){
		if ((name.Contains ("NW") && col.gameObject.name.Contains ("NW")) ||
			(name.Contains ("SW") && col.gameObject.name.Contains ("SW")) ||
			(name.Contains ("NE") && col.gameObject.name.Contains ("NE")) ||
			(name.Contains ("SE") && col.gameObject.name.Contains ("SE")))
			isMirrorOnPlace = false; 
	}
}
