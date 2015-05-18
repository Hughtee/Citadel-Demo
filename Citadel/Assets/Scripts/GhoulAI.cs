using UnityEngine;
using System.Collections;

public class GhoulAI : MonoBehaviour 
{

	private Vector3 Player;
	private Vector2 playerDirection;
	private float Xdif;
	private float Ydif;
	public float speed = 3.0f;
	private int Wall;
	private float distance;


	void Start (){

		Wall = 1 << 10;
	}

	void Update () 
	{
		distance = Vector2.Distance (Player, transform.position);
		Player = GameObject.Find ("Player").transform.position;
		if (distance < 10) 
		{
						Xdif = Player.x - transform.position.x;
						Ydif = Player.y - transform.position.y;

						playerDirection = new Vector2 (Xdif, Ydif);

						if (!Physics2D.Raycast (transform.position, playerDirection, 7, Wall)) {
						
								GetComponent<Rigidbody2D> ().AddForce (playerDirection.normalized * speed);
						}
				}
	}

}

