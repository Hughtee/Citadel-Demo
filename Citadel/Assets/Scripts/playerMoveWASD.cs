using UnityEngine;
using System.Collections;

public class playerMoveWASD : MonoBehaviour 
{

	public float speed;


	void FixedUpdate ()
	{
		if (Input.GetKey(KeyCode.D))
		{
			rigidbody2D.velocity =(Vector2.right *speed);

		}
		else if (Input.GetKey(KeyCode.A))
		{
			rigidbody2D.velocity = (-Vector2.right *speed);

		}
		else if (Input.GetKey(KeyCode.W))
		{
			rigidbody2D.velocity = (Vector2.up *speed);

		}
		else if (Input.GetKey(KeyCode.S))
		{
			rigidbody2D.velocity = (-Vector2.up *speed);

		}
		else
		{
			rigidbody2D.velocity = new Vector2(0,0);
		}
	
	}
}

