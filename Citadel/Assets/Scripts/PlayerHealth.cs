using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
	public float Health = 100f;
	private SpriteRenderer healthbar;
	private Vector3 healthscale;
	//private float hitPause = 0.5f;
	private float HitTime = 0;

	public Material Default;
	public Material Hit;



	void Start () 
	{
		healthbar = GameObject.Find ("GreenHealth").GetComponent<SpriteRenderer>();
		healthscale = healthbar.transform.localScale;


	}

	void Update () 
	{
		HealthUpdate ();

		if (Time.time > HitTime + 0.1f)  
		{

			GetComponent <SpriteRenderer> ().material = Default;	
		
		}


	}

	public void addHealth ()
	{
		Health += 10f;

		if (Health > 100) 
			Health = 100;

	}
	public void minusHealth ()
	{
		Health -= 1f;
		
	
		
	}


	void HealthUpdate () 
	{
		healthbar.transform.localScale = new Vector3 (healthscale.x * Health * 0.01f, 1, 1);

		if (Health > 100) 
			Health = 100;
	}

	public void TakeDamage (float damage, Vector3 enemyPos, float pushBack)
	{

		if (Time.time > HitTime + 0.3f) 
		{
						HitTime = Time.time;
						Health -= damage;
						if (Health <= 0) 
								Health = 0;
						//	Application.LoadLevel ("GameOver");
						if (Health > 100) 
								Health = 100;
						GetComponent <SpriteRenderer> ().material = Hit;
						Vector2 pushDir = transform.position - enemyPos;
						pushDir = pushDir.normalized;
						GetComponent<Rigidbody2D> ().AddForce (pushDir * pushBack);
						
				} 


	}

	
	void OnTriggerEnter2D(Collider2D col)
	{
		
		if (col.tag == "Player")
		{

			Destroy(gameObject);
			addHealth();
		}
		if (col.tag == "Projectile")
		{

			minusHealth();

		}
	}
}


