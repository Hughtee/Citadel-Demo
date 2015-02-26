using UnityEngine;
using System.Collections;

public class Sword : MonoBehaviour 
{
	public playerMoveWASD.Direction direction;
	playerMoveWASD player;

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
				//(other.gameObject.tag == "Enemy")
				{
					Destroy (other.gameObject);
				}
			}
		}
	}
}
