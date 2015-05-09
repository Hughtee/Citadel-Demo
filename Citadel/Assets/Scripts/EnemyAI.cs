﻿using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour 
{

	public float damage = 5;
	public float pushBack = 100;
	public Transform Player;
	public float speed = 4;
	public float stunWait = 3;
	public float stunTimeStamp = -3;
	
	//private CircleCollider2D collider; 


	void Update () 
	{
		if(Player == null)
			Player = GameObject.Find ("Player").transform;

		//if(Time.time > stunTimeStamp + stunWait)
		{
			Vector2 dir =  Player.position - transform.position ;
			int mask = ~( 1 << 8 );
			RaycastHit2D hit = Physics2D.Raycast (transform.position, dir, 12, mask );
			if(hit.transform != null)
			{
				//Debug.Log (hit.transform.tag);
				if (hit.transform.tag == "Player") 
				{
					Debug.DrawRay (transform.position, dir, Color.green);
					if( Mathf.Abs( GetComponent<Rigidbody2D>().velocity.x) < speed &&
					   Mathf.Abs( GetComponent<Rigidbody2D>().velocity.y ) < speed )
					{
						GetComponent<Rigidbody2D>().AddForce (dir * speed);
					}
				}

			}
			else {
				//Debug.Log ("Could not find player");
			}
		}
	}

		


}