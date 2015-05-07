using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour
{

		public float time;
		public GUIText timer;
		public PlayerHealth playerhealth;
		public FadeInOut fade;

		void Start ()
		{
			time = 60;
		}
	
		
		void Update()
		{
			
						timer.text = time.ToString ("F0");
						time -= Time.deltaTime;	


						if (time > 60) 
								time = 60;		
						if (playerhealth.Health <= 0f) {
			
								timer.text = "Finished";
		
								//Application.LoadLevel ("GameOver");
								StartCoroutine( ChangeLevel ( "GameOver") );
						}
		
						if (time <= 0 && playerhealth.Health > 0f) {
			
								timer.text = time.ToString ("F0");
								time -= Time.deltaTime;
								if (time > 60) 
									time = 60;
								//Application.LoadLevel ("Winner");
								StartCoroutine( ChangeLevel ( "Winner") );

						}	
				
		}
		public void addTime ()
		{
				time += 10f;


		}

	//bool isRunning = false;
	IEnumerator ChangeLevel( string levelName )
	{
		GetComponent<GUIText>().enabled = false;

		float fadeTime = fade.BeginFade (1);
		yield return new WaitForSeconds (3.0f);
		Application.LoadLevel (levelName);
	}
}













