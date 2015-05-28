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
	public PlayerHealth health;
	private float H_Move;
	private float V_Move;

	public bool handleTouch = true;
	public bool attack_key;

	private playerAnimation pA;

	void Start( ) {
		pA = gameObject.GetComponent<playerAnimation> ();
		pA.handleTouch = handleTouch;
	}

	void Update ()
	{

	}


	// Update is called once per frame
	void FixedUpdate () 
	{
		if (!handleTouch) 
		{
			V_Move = Input.GetAxis ("Vertical");
			H_Move = Input.GetAxis ("Horizontal");
		}

		GetComponent<Rigidbody2D >().velocity = new Vector2 (V_Move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
		GetComponent<Rigidbody2D>().velocity = new Vector2 (H_Move * maxSpeed, GetComponent<Rigidbody2D>().velocity.x);

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

	public void StartMoveHorizontal ( float val)
	{
		//Debug.Log ("Clicked StartMove H");
		H_Move = val;

		if (val > 0) {
			pA.right_key = true;
		} else {
			pA.left_key = true;
		}
	}

	public void EndMoveHorizontal ( float val)
	{
		//Debug.Log ("Clicked StartMove H");
		H_Move = 0;
		pA.right_key = false;
		pA.left_key = false;
	}

	public void StartMoveVertical ( float val)
	{
		//Debug.Log ("Clicked StartMove H");
		V_Move = val;
		if (val > 0) {
			pA.up_key = true;
		} else {
			pA.down_key = true;
		}
	}
	
	public void EndMoveVertical ( float val)
	{
		//Debug.Log ("Clicked StartMove H");
		V_Move = 0;
		pA.up_key = false;
		pA.down_key = false;
	}

	public void StartAttack( ) {
		attack_key = true;
		pA.attack_key = true;
	}

	public void EndAttack( ) {
		attack_key = false;
		pA.attack_key = false;
	}
}

