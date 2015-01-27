using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {


	public float speed;
	public Transform player;



	
	// Update is called once per frame
	void FixedUpdate () 
	
	{
	
		float z = Mathf.Atan2 ((player.transform.position.y - Transform.position.y), (PlayerMoves.transform.position.x - Transform.position.x)) * Mathf.Rad2Deg - 90;


		transform.eulerAngles = new Vector3 (0, 0, z);

		rigidbody2D.AddForce (gameObject.transform.up * speed);


	}
}
