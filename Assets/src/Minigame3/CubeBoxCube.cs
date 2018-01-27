using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCubeBox : MonoBehaviour {

	Vector3 cubePosition;
	Vector3 mousePosition;
	Vector3 offsetVector;

	float offset;
	float dragheight;

	// Use this for initialization
	void Start () 
	{
		offset = 10f;
		cubePosition = transform.position;	
		dragheight = 5.5f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		offsetVector = mousePosition - cubePosition;
	}

	void OnMouseDown()
	{
		if (Mathf.Abs(offsetVector.x) < offset && Mathf.Abs(offsetVector.x) < offset && Mathf.Abs(offsetVector.x) < offset)
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
