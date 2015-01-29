using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {


	private Vector3 Player;
	private Vector2 Playerdirection;
	private float XDif;
	private float YDif;
	
	void Start () 
	{
	
	}
	

	void Update () 
	{
		Player = GameObject.Find ("Player").transform;


		XDif = Player.x - transform.positionX;
		yDif = Player.Y - transform.positionY;
	
		Playerdirection = new Vector2 (XDiff, YDiff);
		

			rigibody2D.AddForce (Playerdirection.normalized * speed);
	}
}	
