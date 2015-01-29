using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {


	private Vector3 Player;
	private Vector2 Playerdirection;
	private float XDiff;
	private float YDiff;
	 public float speed;
	private int Wall;
	private float distance;
	private bool stun;
	private float stuntime;




	void Start ()
	{
		stuntime = 0;
		Wall = 1 << 10;
		stun = false;
	
	
	
	} 

	void Update () 
	{
		distance = Vector2.Distance (Player, transform.position);
		Player = GameObject.Find ("Player").transform.position;
		if (stuntime > 0) {
						stuntime -= Time.deltaTime;
				} 
		else {
				
			stun=false;
		}



		if (distance < 10 && !stun) 
		{
			XDiff = Player.x - transform.position.x;
			YDiff = Player.y - transform.position.y;
			Playerdirection = new Vector2 (XDiff, YDiff);
			}


		if (!Physics2D.Raycast (transform.position, Playerdirection, 6, Wall)) 
		{

		rigidbody2D.AddForce (Playerdirection.normalized * speed);
				
		}
	}

	void OnCOllisionEnter2D (Collision2D Playerhit) {

		if(Playerhit.gameObject.tag == "Player")
		{
			stuntime = 1;
			stun=true;
		}
		}











}	
