using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
//using System;
using System.IO;
using SimpleJSON;
//using Newtonsoft.Json.Linq
//using LitJSON;

public class getUrl : MonoBehaviour {

	public float offsetfloat;

	// Use this for initialization
	IEnumerator Start () {

		//select the channels from random position
		float offsetrandfloat = Random.Range(0, offsetfloat);
		int offsetrand = Mathf.RoundToInt (offsetrandfloat);
		string offset = "offset=" + offsetrand;

		//get 20 channels
		UnityWebRequest www = UnityWebRequest.Get ("http://api.dirble.com/v2/stations?" + offset + "&token=8a3834b981c1bbad181e0ad725");

		yield return www.SendWebRequest();

		if(www.isNetworkError || www.isHttpError) {
			Debug.Log(www.error);
		}
		else {
			// Show results as text
//			Debug.Log(www.downloadHandler.text);

			// Or retrieve results as binary data
			byte[] results = www.downloadHandler.data;
		}

		//set 20 channels to jsonnode object
		string jsonstring = www.downloadHandler.text;
		string jsonstring2 = "{\"Items\":" + jsonstring + "}";
		JSONNode jsonobj = JSONNode.Parse(jsonstring2);

		//send found channels to player
		bassstream.json = jsonobj;
		bassstream.Play ();

		//play the first channel
		//bassstream.Play(jsonobj[0][0][10][0][0]);

		//play second channel
		//Debug.Log (jsonobj[0][1][10][0][0]);

		//etc
		//Debug.Log (jsonobj[0][2][10][0][0]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}