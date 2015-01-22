using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour 
{
	public GameObject target;
	public float Attackrange=10f;
	public float moveSpeed = 2f;
	public float HP = 2;


	public LayerMask collideMask;

	private Transform frontCheck;

	private bool dead = false;

	private CharacterController controller;

	void Start ()
	{
		controller = gameObject.GetComponent<CharacterController>();
		
		//Find the player gameobject
		target = GameObject.FindGameObjectWithTag("Player");
	}	
	//AI attack range
	 
	void Update() 
	{
		

		/*if(Vector2.Distance(transform.position, target.transform.position)<Attackrange) 
		{
			transform.LookAt (target.transform.position);
			controller.SimpleMove(transform.forward *2)
			Debug.Log("Moving to Player");
		}*/
		if( HP <= 0)
		{
			Destroy(gameObject);
			Debug.Log("Enemy Dead");
		}
	}




	void Awake()
	{
		frontCheck = transform.Find ("FrontCheck").transform;
	}
	public void TakeDamage( float damage )
	{
		HP = HP - damage;
		Debug.Log( "HitPoints : " +HP);
	}

	
	// Update is called once per frame
	void FixedUpdate () 
	{
		Collider2D[] fronthits = Physics2D.OverlapPointAll (frontCheck.position, collideMask);

		foreach (Collider2D c in fronthits) 
		{
			if(c.tag == "Obstacle" || c.tag == "Enemy")
			{
				Flip();
			}

			if(c.tag == "Player")
			{
				print ("Player damaged!!!");
				Hurt ();
				Flip ();
			}

		}

		rigidbody2D.velocity = new Vector2(transform.localScale.x * moveSpeed, rigidbody2D.velocity.y);

		if (HP <= 0 && !dead) 
		{
			Death();
		}
	}
	public void Hurt()
	{
		HP--;
	}
	void Death()
		{
		SpriteRenderer[] otherRenderers = GetComponentsInChildren<SpriteRenderer> ();

		foreach (SpriteRenderer s in otherRenderers)
				{
					s.enabled =false;
				}

			dead = true;

			Collider2D[] cols = GetComponents <Collider2D> ();

			foreach(Collider2D c in cols)
				{
					//c.isTrigger = true;
				}
		}
	public void Flip()
		{
			Vector3 enemyScale = transform.localScale;
			enemyScale.x *= -1;
			transform.localScale = enemyScale;
		}

}
