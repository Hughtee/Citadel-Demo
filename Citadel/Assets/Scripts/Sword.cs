using UnityEngine;
using System.Collections;

public class Sword : MonoBehaviour 
{
	public playerMoveWASD.Direction direction;
	playerMoveWASD player;
	public GameObject[] Items;
	public Timer timer;
	public int killValue = 1;

	void Start()
	{
		player = FindObjectOfType<playerMoveWASD> ();
	}

	void OnTriggerStay2D (Collider2D other)
	{
		if(Input.GetButtonDown("Fire1") )
		{
			if(direction == player.direction)
			{
				if(other.gameObject.tag == "Enemy")
				{
					Destroy (other.gameObject);
					timer.addTime();
					KillScript.score += killValue;
					Instantiate(Items[Random.Range(0, Items.Length)], transform.position, Quaternion.identity);

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
			}
		}
	}
}
