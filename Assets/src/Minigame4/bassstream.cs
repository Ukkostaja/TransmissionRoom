using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

public class bassstream : MonoBehaviour {

	public string url;
	private int stream;


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
	void Start () {
		if ( BASS_Init(-1, 44100,0,IntPtr.Zero, IntPtr.Zero) )
		{
			BASS_SetConfig(configs.BASS_CONFIG_NET_PLAYLIST,2);
			stream = BASS_StreamCreateURL(url, 0, flags.BASS_DEFAULT, IntPtr.Zero, IntPtr.Zero);

			if (stream != 0)
				BASS_ChannelPlay(stream, false);          
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnApplicationQuit()
	{
		BASS_StreamFree(stream);
		BASS_Free();
	}
}
