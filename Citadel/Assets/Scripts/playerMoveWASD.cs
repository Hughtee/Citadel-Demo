using UnityEngine;
using System.Collections;

public class playerMoveWASD : MonoBehaviour 
{

	public float speed;
	public Animator anim;

	void Start ()
	{
		anim = GetComponent<Animator> ();
	}
	void Update ()
	{
		if (Input.GetKey(KeyCode.D))
		{
			transform.Translate (Vector2.right *speed);
			anim.SetBool("Right",true);
		}
		if (Input.GetKey(KeyCode.A))
		{
			transform.Translate (-Vector2.right *speed);
			anim.SetBool("Right",true);
		}
		if (Input.GetKey(KeyCode.W))
		{
			transform.Translate (Vector2.up *speed);
			anim.SetBool("Up",true);
		}
		if (Input.GetKey(KeyCode.S))
		{
			transform.Translate (-Vector2.up *speed);
			anim.SetBool("Down",true);
		}
	}

}
