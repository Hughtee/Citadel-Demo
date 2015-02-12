using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	public int time;
	public GUIText timer;
	public PlayerHealth playerhealth;

	void Start()
	{
		StartCoroutine (countdown());
	}
	
	IEnumerator countdown()
	{
		while (time > 0)
		{
			yield return new WaitForSeconds(1);
			
			timer.text = time.ToString();
			
			time -= 1;
		}
		
		timer.text = "Finished";
	
		if (time == 0 && playerhealth.Health <= 0f) {
	
	
			Application.LoadLevel ("GameOver");
		}
		else
		{
			Application.LoadLevel ("Winner");
		}
	}










}



