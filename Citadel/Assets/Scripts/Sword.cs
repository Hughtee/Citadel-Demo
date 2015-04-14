﻿using UnityEngine;
using System.Collections;

public class Sword : MonoBehaviour 
{
	public playerMoveWASD.Direction direction;
	playerMoveWASD player;

	public Timer timer;

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
				}
			}
		}
	}
}
