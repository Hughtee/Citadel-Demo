using UnityEngine;
using System.Collections;

public class playerMoveWASD : MonoBehaviour 
{
	public enum Direction
	{
		North,
		South,
		East,
		West
	};

	public Direction direction = Direction.South;
	public float maxSpeed= 10.0f;
	
	public bool FacingLeft = false;
	public bool FacingRight = false ;
	public bool FacingUp = false;	

	void Update ()
	{

	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		float H_move = Input.GetAxis ("Vertical");
		GetComponent<Rigidbody2D>().velocity = new Vector2 (H_move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
		
		float V_move = Input.GetAxis ("Horizontal");
		GetComponent<Rigidbody2D>().velocity = new Vector2 (V_move * maxSpeed, GetComponent<Rigidbody2D>().velocity.x);

		if(GetComponent<Rigidbody2D>().velocity.magnitude >0.1f)
		{
			if(GetComponent<Rigidbody2D>().velocity.x > 0.1f)
				direction = Direction.East;
			if(GetComponent<Rigidbody2D>().velocity.x < -0.1f)
				direction = Direction.West;
			if(GetComponent<Rigidbody2D>().velocity.y > 0.1f)
				direction = Direction.North;
			if(GetComponent<Rigidbody2D>().velocity.y < -0.1f)
				direction = Direction.South;
		}
	}
}

