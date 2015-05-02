using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour
{

		public float time;
		public GUIText timer;
		public PlayerHealth playerhealth;

		void Start ()
		{
				time = 60;



				//StartCoroutine (countdown());
		}
	
		/*IEnumerator countdown()
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
*/
		void Update ()
		{
				
		timer.text = time.ToString ("F0");
		time -= Time.deltaTime;	


			if (time > 60) 
				time = 60;		



		if (time < 0 && playerhealth.Health == 0f) {
			
						timer.text = "Finished";
						Application.LoadLevel ("GameOver");
				}  

		if (time <= 0 && playerhealth.Health > 0f)
		{
						
						/*timer.text = time.ToString ("F0");
						time -= Time.deltaTime;


						if (time > 60) 
							time = 60;
							*/
			timer.text = "Finished";
			Application.LoadLevel ("Winner");

		}


	
		}

		public void addTime ()
		{
				time += 10f;


		}

}













