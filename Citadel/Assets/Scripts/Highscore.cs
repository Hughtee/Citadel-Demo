using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Highscore : MonoBehaviour {

	Text HighscoreTable;
	KillScript  highscores;
	
		// Use this for initialization
	void Start ()
	{
		highscores = GameObject.Find ("score").GetComponent<KillScript> ();
		HighscoreTable = GetComponent<Text> ();

		if (highscores == null)
			throw new MissingReferenceException ("Requires a Score GameObject with a HighScore component");

		if (HighscoreTable == null)
			throw new MissingReferenceException ("Requires a Text GameObject for the scorelist");
			
	}

}
