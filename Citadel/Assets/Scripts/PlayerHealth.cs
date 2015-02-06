using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
	public float Health = 100f;
	private SpriteRenderer healthbar;
	private Vector3 healthscale;
	private float hitPause = 0.5f;
	private float lastHitTime = 0;

	void Start () 
	{
		healthbar = GameObject.Find ("GreenHealth").GetComponent<SpriteRenderer>();
		healthscale = healthbar.transform.localScale;
	}

	void Update () 
	{
		HealthUpdate ();
	}


	void HealthUpdate () 
	{
		healthbar.transform.localScale = new Vector3 (healthscale.x * Health * 0.01f, 1, 1);
	}

	public void TakeDamage (float damage, Vector3 enemyPos, float pushBack)
	{

		if (Time.time > lastHitTime + hitPause)
		{
			Health -= damage;
			if (Health <= 0) 
				Application.LoadLevel ("GameOver");
			if (Health > 100) 
				Health = 100;

			Vector2 pushDir = transform.position - enemyPos;
			pushDir = pushDir.normalized;
			rigidbody2D.AddForce (pushDir * pushBack);
		}
	}
}


