using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour 
{

	public float damage = 5;
	public float pushBack = 100;
	private Transform Player;
	public float speed = 4;
	public float stunWait = 3;
	public float stunTimeStamp = -3;
	

	void Update () 
	{
		if(Player == null)
			Player = GameObject.Find ("Player").transform;

		if(Time.time > stunTimeStamp + stunWait)
		{
			Vector2 dir =  Player.position - transform.position ;
			RaycastHit2D hit = Physics2D.Raycast (transform.position, dir, 12);
			if(hit.transform!= null)
			{
				if (hit.transform.tag == "Player") 
				{
					Debug.DrawRay (transform.position, dir, Color.green);
					GetComponent<Rigidbody2D>().AddForce (dir* speed);
				}
			}
		}
	}

	void OnCollisionEnter2D (Collision2D Playerhit) 
	{
		if(Playerhit.gameObject.tag == "Player")
		{
			stunTimeStamp = Time.time;
			PlayerHealth ph = Playerhit.gameObject.GetComponent<PlayerHealth>();
			ph.TakeDamage(damage, transform.position, pushBack);
		}
	}











}	
