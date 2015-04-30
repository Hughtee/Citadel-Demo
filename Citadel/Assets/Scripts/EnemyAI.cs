using UnityEngine;
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
	
	float SW = 0.78539816f; // 45
	float SE = 2.35619449f; // 135
	float NE = 3.92699082f; // 225
	float NW = 5.49778714f; // 315
	float PI = 3.14159265f; // 180

	

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

	/*void OnCollisionEnter2D (Collision2D Playerhit) 
	{
		if(Playerhit.gameObject.tag == "Player")
		{
			stunTimeStamp = Time.time;
			PlayerHealth ph = Playerhit.gameObject.GetComponent<PlayerHealth>();
			ph.TakeDamage(damage, transform.position, pushBack);
		} */
	void OnTrigger2D (Collider2D collider)
	{
		if (collider.CompareTag ("Player")) {				
			
			if( isInsidePieSlice ( collider.transform.position, SW, SE ) ) {
				Debug.Log( "COLLIDED SOUTH" );
			}
			else if( isInsidePieSlice ( collider.transform.position, SE, NE ) ) {
				Debug.Log( "COLLIDED EAST" );
			}
			else if( isInsidePieSlice ( collider.transform.position, NE, NW ) ) {
				Debug.Log( "COLLIDED NORTH" );
			}
			else {
				Debug.Log( "COLLIDED WEST" );
			}
		}
	}
	
	bool isInsidePieSlice (Vector3 pos, float startAngle, float endAngle )
	{
		float posAngle = Mathf.Atan2( pos.y - transform.position.y, pos.x - transform.position.x );
		posAngle += PI;
		
		if (startAngle < posAngle && endAngle > posAngle) {
			return true;
		} else {
			return false;
		}
	}

}	
