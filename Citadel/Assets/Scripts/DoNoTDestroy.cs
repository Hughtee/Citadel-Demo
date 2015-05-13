using UnityEngine;
using System.Collections;

public class DoNoTDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		DontDestroyOnLoad (gameObject);
	}
	

}
