using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {
	public Transform Player;
	public float pushBack = 100;
	public float damage = 25;
	public float stunTimeStamp = -3;
	public Animator anim;

	float SW = 0.78539816f; // 45
	float SE = 2.35619449f; // 135
	float NE = 3.92699082f; // 225
	float NW = 5.49778714f; // 315
	float PI = 3.14159265f; // 180
	



	void Start ()

	{
		anim = GetComponent<Animator>();
		}






	void OnTrigger2D (Collider2D collider)
	{
		if (collider.CompareTag ("Player")) 
		{				

			anim.SetBool ("Attack", true);

			if( isInsidePieSlice ( collider.transform.position, SW, SE ) ) 
			{
				Debug.Log( "COLLIDED SOUTH" );
				anim.SetBool ("Down", true);

			}
			else if( isInsidePieSlice ( collider.transform.position, SE, NE ) ) 
			{
				Debug.Log( "COLLIDED EAST" );
				anim.SetBool ("Right", true);
			}
			else if( isInsidePieSlice ( collider.transform.position, NE, NW ) ) 
			{
				Debug.Log( "COLLIDED NORTH" );
				anim.SetBool ("Up", true);
			}
			else {
				Debug.Log( "COLLIDED WEST" );
				anim.SetBool ("Left", true);
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
	bool isInsidePieSlice (Vector3 pos, float startAngle, float endAngle )
	{
		float posAngle = Mathf.Atan2( pos.y - transform.position.y, pos.x - transform.position.x );
		posAngle += PI;
		
		if (startAngle < posAngle && endAngle > posAngle) 
		{
			return true;
		} 
		else {
			return false;
		}
	}



}
