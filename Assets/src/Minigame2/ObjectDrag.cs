using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDrag : MonoBehaviour {

	Vector3 dragObjectPosition;
	Vector3 mousePosition;
	Vector3 offsetVector;
	bool isCliked;

	public float dragheight;
	public float offset;


	// Use this for initialization
	void Start () {
		if (offset == 0) dragheight = offset = 10f;
		dragObjectPosition = transform.position;
		if (dragheight == 0) dragheight = dragObjectPosition.y;
	}
	
	// Update is called once per frame
	void Update () {
		mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		offsetVector = mousePosition - dragObjectPosition;

	}

	void HandlePuzzle2Objects(){
		if (this.gameObject.tag == "Puzzle2Block" || this.gameObject.tag == "Puzzle2Mirror") {
			Rigidbody rb;
			rb = GetComponent<Rigidbody> ();
			if (!isCliked) {
				rb.velocity = Vector3.zero;
				rb.Sleep();
			}
		} else
			return;
	}

	void OnMouseDown()
	{
		HandlePuzzle2Objects ();
		if (Mathf.Abs(offsetVector.x) < offset && Mathf.Abs(offsetVector.y) < offset && Mathf.Abs(offsetVector.z) < offset)
		{
			transform.position = new Vector3(mousePosition.x, dragheight, mousePosition.z);
			dragObjectPosition = transform.position;
			isCliked = true;
		}
	}

	void OnMouseDrag()
	{
		transform.position = new Vector3 (mousePosition.x, dragheight, mousePosition.z);
		dragObjectPosition = transform.position;
	}

	void OnMouseUp()
	{
		HandlePuzzle2Objects ();
		transform.position = new Vector3 (mousePosition.x, dragheight, mousePosition.z);
		dragObjectPosition = transform.position;
		isCliked = false;
	}
}
