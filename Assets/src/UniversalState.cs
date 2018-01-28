using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Universal class for storing game states. States are stored as integers. 
 * If individual state variable is utilized as "true-false-variable"
 * true = 1 and false = 0
 */
public static class UniversalState{

	// variables for storing game states //

	private static int miniGame1Solved = 0;
	public static int MiniGame1Solved{
		get { return miniGame1Solved; }
		set { miniGame1Solved = value; }
	}

	private static int miniGame2Solved = 0;
	public static int MiniGame2Solved{
		get { return miniGame2Solved; }
		set { miniGame2Solved = value; }
	}

	private static int miniGame3Solved = 0;
	public static int MiniGame3Solved{
		get { return miniGame3Solved; }
		set { miniGame3Solved = value;}
	}

	private static int miniGame4Solved = 0;
	public static int MiniGame4Solved{
		get { return miniGame4Solved; }
		set { miniGame4Solved = value; }
	} 

	private static int miniGame5Solved = 0;
	public static int MiniGame5Solved{
		get { return miniGame5Solved; }
		set { miniGame5Solved = value; }
	} 

	private static int miniGame6Solved = 0;
	public static int MiniGame6Solved{
		get { return miniGame6Solved; }
		set { miniGame6Solved = value; }
	} 

	private List<int> miniGameSolvedList;
	public static List<int> MiniGameSolvedList {
		get { return miniGame1Solved; }
		set { miniGame1Solved = value; }
	}
}
