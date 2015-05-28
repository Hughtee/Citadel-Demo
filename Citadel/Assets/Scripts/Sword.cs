using UnityEngine;
using System.Collections;

public class Sword : MonoBehaviour 
{
	public playerMoveWASD.Direction direction;
	playerMoveWASD player;
	public Timer timer;
	public int killValue = 1;
	public PlayerHealth Health;

	void Start()
	{
		player = FindObjectOfType<playerMoveWASD> ();
	}

	void OnTriggerStay2D (Collider2D other)
	{
		if( (Input.GetButtonDown("Fire1") && !player.handleTouch) ||
		     (player.handleTouch && player.attack_key) )
		{
			if(direction == player.direction)
			{
				if(other.gameObject.tag == "Enemy")
				{
					Destroy (other.gameObject);
					//timer.addTime();
					KillScript.score += killValue;
					//Instantiate(Items[Random.Range(0, Items.Length)], transform.position, Quaternion.identity);

					if (timer.time > 60) 
						timer.time = 60;
				}
				else if(other.gameObject.tag == "Enemy02")
				{
					Destroy (other.gameObject);
					KillScript.score += killValue;

				}
				else if(other.gameObject.tag == "Enemy03")
				{
					Destroy (other.gameObject);
					KillScript.score += killValue;
					
				}
				else if(other.gameObject.tag == "Health")
				{
					Destroy (other.gameObject);
					KillScript.score += killValue;
					Health.addHealth();

					
				}
				else if(other.gameObject.tag == "Time")
				{
					Destroy (other.gameObject);
					KillScript.score += killValue;
					timer.addTime();
					
					
				}
			}
		}
	}
}
