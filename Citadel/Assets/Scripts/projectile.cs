using UnityEngine;
using System.Collections;

public class projectile : MonoBehaviour 
{
	public float speed= 20;
	public float GivenDamage=5f;
	public float projectileLife=2f;
	
	// Use this for initialization
	void Start () 
	{
		Destroy(gameObject,projectileLife); 

	}
	
	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Collider")
		{
			Destroy(gameObject);

		}
		if (collision.gameObject.tag == "Enemy")
		{
			Destroy(gameObject);
			
			collision.gameObject.SendMessage("TakeDamage", GivenDamage, SendMessageOptions.DontRequireReceiver);

			Debug.Log ("projectile has hit ENEMY");
		}
	}
}
