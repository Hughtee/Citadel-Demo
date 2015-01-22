using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

	
	public float speed=6.0f;
	float moveDirection;
	bool facingRight = true;






	// Use this for initialization
	void Awake () 
	{

	}
	
	
	void FixedUpdate()
	{
		rigidbody.velocity = new Vector2 (moveDirection * speed, rigidbody.velocity.y);




		if (moveDirection> 0.0f && facingRight) 
		{

						Flip ();
				} 
		else if (moveDirection< 0.0f && !facingRight) 
		{

			Flip();


				}
	
	
	
	}
	
	
	
	// Update is called once per frame
	void Update () 
	{

		moveDirection = Input.GetAxis ("Horizontal");
		

}

	void Flip()
	{

		facingRight = !facingRight;
		transform.Rotate (Vector3.up, 180.0f, Space.World);

		}




}
