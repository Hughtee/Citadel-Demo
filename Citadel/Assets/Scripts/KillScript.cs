using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class KillScript : MonoBehaviour {

	public static int score;


	Text text;
	// Use this for initialization
	void Awake () 
	{
	
		//text = GetComponent <Text> ();
		text = GameObject.Find("KillText").GetComponent<Text>();
		score = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		text.text = "ENEMIES KILLED:" + score;
	
	}
}
