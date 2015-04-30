using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {
	//public PlayerHealth playerhealth;

		
		void OnTriggerEnter2D(Collider2D col)
		{
			
			if (col.tag == "Player")
			{
				//money collected
				col.gameObject.GetComponent<PlayerHealth>().addHealth();
				
				//destroy money object
				Destroy(gameObject);
				
			}
		}

	}

