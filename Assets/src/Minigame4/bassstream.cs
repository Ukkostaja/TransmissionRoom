using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;
using SimpleJSON;
using Random = UnityEngine.Random;

public class bassstream : MonoBehaviour {

//	public static string url;

	public static JSONNode json;

	private static string streamurl;

	private static int stream;

	private static int randomchannel;
	private static float randomfloat;


	public enum flags {
		BASS_DEFAULT
	}

	public enum configs {

		BASS_CONFIG_NET_PLAYLIST=21

	}

	[DllImport("bass")]
	public static extern bool BASS_Init(int device, int freq, int flag,IntPtr hwnd, IntPtr clsid);

	[DllImport("bass")]
	public static extern bool BASS_SetConfig(configs config,int valuer);

	[DllImport("bass")]
	//public static extern Int32 BASS_StreamCreateURL(string url,int offset,   flags flag,  IntPtr user);
	public static extern Int32 BASS_StreamCreateURL (string url, int offset, flags Flag, IntPtr dproc, IntPtr user ) ;

	[DllImport("bass")]
	public static extern bool BASS_ChannelPlay(int steam,bool restart);

	[DllImport("bass")]
	public static extern bool BASS_StreamFree(int stream);

	[DllImport("bass")]
	public static extern bool BASS_Free();



	// Use this for initialization
	public static void Play () {
		
		 
		randomfloat = Random.Range(0, 19);
		randomchannel = Mathf.RoundToInt (randomfloat);
		streamurl = json [0] [randomchannel] [10] [0] [0];

		if ( BASS_Init(-1, 44100,0,IntPtr.Zero, IntPtr.Zero) )
		{
			BASS_SetConfig(configs.BASS_CONFIG_NET_PLAYLIST,2);
			stream = BASS_StreamCreateURL(streamurl, 0, flags.BASS_DEFAULT, IntPtr.Zero, IntPtr.Zero);

			if (stream != 0)
				BASS_ChannelPlay (stream, false);
			else {
				Debug.Log ("stream = 0");
				Debug.Log ("URL = " + streamurl);
			}
		}
	}
	
	// Update is called once per frame
	//TEMPORARY
	//MOVE
	void Update () {
		if (Input.GetKey (KeyCode.E)) {
			BASS_StreamFree (stream);
			BASS_Free ();
			Play ();
		}
	}
	//stop the audio
	void OnApplicationQuit()
	{
		BASS_StreamFree(stream);
		BASS_Free();
	}
}
