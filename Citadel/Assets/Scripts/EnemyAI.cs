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
	public Animator anim;



	public enum EnemyDirection
	{
		North,
		South,
		East,
		West
	};
	
	public EnemyDirection direction = EnemyDirection.South;
	public bool FacingLeft = false;
	public bool FacingRight = false ;
	public bool FacingUp = false;
	public bool Walk = false;
	//private CircleCollider2D collider; 

	void Start ()

	{
		anim = GetComponent<Animator>();
		}
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
					Walk = true;
					Debug.DrawRay (transform.position, dir, Color.green);
					if( Mathf.Abs( GetComponent<Rigidbody2D>().velocity.x) < speed &&
					   Mathf.Abs( GetComponent<Rigidbody2D>().velocity.y ) < speed )
					{
						GetComponent<Rigidbody2D>().AddForce (dir * speed);
					}
				}
				if(GetComponent<Rigidbody2D>().velocity.magnitude >0.1f)
				{	

					if(GetComponent<Rigidbody2D>().velocity.x > 0.1f)
						direction = EnemyDirection.East;
						anim.SetBool ("WalkRight", true);
						Debug.Log ("Enemy Walking East");
					if(GetComponent<Rigidbody2D>().velocity.x < -0.1f)
						direction = EnemyDirection.West;
						anim.SetBool ("WalkLeft", true);
						Debug.Log ("Enemy Walking West");
					if(GetComponent<Rigidbody2D>().velocity.y > 0.1f)
						direction = EnemyDirection.North;
						anim.SetBool ("WalkUp", true);
						Debug.Log ("Enemy Walking North");
					if(GetComponent<Rigidbody2D>().velocity.y < -0.1f)
						direction = EnemyDirection.South;
						anim.SetBool ("WalkDown", true);
						Debug.Log ("Enemy Walking South");
				}
			}
			else {
				//Debug.Log ("Could not find player");
			}
		}
	}

		


}