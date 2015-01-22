using UnityEngine;
using System.Collections;

public class StartMenu : MonoBehaviour 
{

	void Update () 
	{
		if (Input.GetButtonDown ("XboxStart")) 
		{
			Application.LoadLevel(1);
		}
		if (Input.GetKeyDown("space"))
		{
			Application.LoadLevel(1);
		}
	}
}
