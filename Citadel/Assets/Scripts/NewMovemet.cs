using UnityEngine;
using System.Collections;

public class NewMovemet : MonoBehaviour 
{
	public float maxSpeed= 10.0f;

	public bool FacingLeft = false;
	public bool FacingRight = false ;
	public bool FacingUp = false;

	
	Animator anim;




	// Use this for initialization
			void Start () 
			{
			
	
				
			}
			
			// Update is called once per frame
			void Update () 
			{
				float H_move = Input.GetAxis ("Vertical");
				rigidbody2D.velocity = new Vector2 (H_move * maxSpeed, rigidbody2D.velocity.y);
				
			


				float V_move = Input.GetAxis ("Horizontal");
				rigidbody2D.velocity = new Vector2 (V_move * maxSpeed, rigidbody2D.velocity.x);
			}
				

					


}