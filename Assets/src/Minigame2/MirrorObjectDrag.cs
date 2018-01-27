using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorObjectDrag : MonoBehaviour {

	Vector3 dragObjectPosition;
	Vector3 mousePosition;
	Vector3 offsetVector;

	float dragheight;
	float offset;

	// Use this for initialization
	void Start () {
		offset = 5f;
		dragObjectPosition = transform.position;
		dragheight = dragObjectPosition.y;
	}
	
	// Update is called once per frame
	void Update () {
		mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		offsetVector = mousePosition - dragObjectPosition;
	}

	void OnMouseDown()
	{
		if (Mathf.Abs(offsetVector.x) < offset && Mathf.Abs(offsetVector.y) < offset && Mathf.Abs(offsetVector.z) < offset)
		{
			transform.position = new Vector3(mousePosition.x, dragheight, mousePosition.z);
		}
	}

	void OnMouseDrag()
	{
		transform.position = new Vector3 (mousePosition.x, dragheight, mousePosition.z);
	}

	void OnMouseUp()
	{
		transform.position = new Vector3 (mousePosition.x, dragheight, mousePosition.z);
	}
}
