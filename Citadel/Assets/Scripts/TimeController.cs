using UnityEngine;
using System.Collections;

public class TimeController : MonoBehaviour {

	float timeLeft = 30.0f;
	
	void Update()
	{
		timeLeft -= Time.deltaTime;
		if(timeLeft < 0)
		{
			Application.LoadLevel ("Gameover");
		}
	}





}
