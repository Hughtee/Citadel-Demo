using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
	public float Health = 100f;
	private SpriteRenderer healthbar;
	private Vector3 healthscale;
	private float HitTime;

	void Start () {
		healthbar = GameObject.Find ("GreenHealth").GetComponent<SpriteRenderer>();
		healthscale = healthbar.transform.localScale;
		}

	void Update () {

				if (Health <= 0) {

						Application.LoadLevel ("GameOver");

				}

				if (Health > 100) {
						Health = 100;
				}
			HealthUpdate ();


		}


	void HealthUpdate () {

		healthbar.transform.localScale = new Vector3 (healthscale.x * Health * 0.01f, 1, 1);



		}
	void OnCollisionStay2D (Collision2D EnemyHit){


		if (EnemyHit.gameObject.tag == ("Enemy")) 
						

			if (HitTime + 0.5f < Time.time)


			HitTime = Time.time;
						Health -= 5;
		

		float verticalpush = EnemyHit.gameObject.transform.position.y - transform.position.y;
		float horizontalpush = EnemyHit.gameObject.transform.position.x - transform.position.x;

		rigidbody2D.AddForce (new Vector2 (-horizontalpush, -verticalpush * 1000));
		
		    }
}


