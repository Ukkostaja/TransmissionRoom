using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public interface Triggable {

	void OnTriggerEnter (Collider col);

	void OnTriggerStay (Collider col);

	void OnTriggerLeave (Collider col);
}
