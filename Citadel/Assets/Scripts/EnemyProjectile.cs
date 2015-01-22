using UnityEngine;
using System.Collections;

public class EnemyProjectile : MonoBehaviour
{
	
public float GivenDamage=5f;
public float projectileLife=2f;

// Use this for initialization
	void Start () 
	{
		Destroy(gameObject,projectileLife); 
	}

	void OnCollisionEnter2D(Collision2D collision)
	{

			if (collision.gameObject.tag == "Player")
			{
				Destroy(gameObject);
				
				collision.gameObject.SendMessage("TakeDamage", GivenDamage, SendMessageOptions.DontRequireReceiver);
				
				Debug.Log ("projectile has hit Player");
			}
	}
}
