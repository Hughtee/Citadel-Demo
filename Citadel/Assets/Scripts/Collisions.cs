using UnityEngine;
using System.Collections;

public class Collisions : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter2D (Collision2D coll)
	{
		Debug.Log ("Collision Event.");
	}
	
	// Update is called once per frame
	void OnCollisionStay2D (Collision2D coll)
	{
		Debug.Log ("Collision Stay Event.");
	}


	void OnCollisionExit2D (Collision2D coll)
	{
		Debug.Log ("Collision Exit Event.");



}
}