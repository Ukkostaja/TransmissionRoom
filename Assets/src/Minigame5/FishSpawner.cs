using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour {

	public float spawnDelay =1;
	private float lastSpawn = 0;
	public GameObject prefab;
	public float AreaScale;
	public Sprite[] catches;

	// Use this for initialization
	void Start () {
		Spawn ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad > lastSpawn + spawnDelay) {
			lastSpawn = Time.timeSinceLevelLoad;
			Spawn ();

		}
	}

	void Spawn () {
		float x = Random.value -0.5f;
		float z = Random.value -0.5f;
		//Debug.Log (x + " , " + z);
		Vector3 pos = new Vector3 (transform.position.x + x * AreaScale, 0f,transform.position.z + z * AreaScale);
		GameObject.Instantiate (prefab, pos, transform.rotation, transform);
		Transform madness = transform.transform.transform.transform.transform.transform.transform.transform;
	}

}
