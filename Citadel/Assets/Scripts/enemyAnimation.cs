using UnityEngine;
using System.Collections;

public class enemyAnimation : MonoBehaviour {

	private Animator anim;


	void Start () 
	{
		anim = GetComponent <Animator> ();

	}
	

	void Update () 
	{
		if (GetComponent<Rigidbody2D>().velocity.x > 0.1) 
		{
			anim.SetBool ("WalkRight",true);
			anim.SetBool ("Right",true);
			anim.SetBool ("WalkLeft",false);
			anim.SetBool ("Left",false);
				}
		if (GetComponent<Rigidbody2D>().velocity.x < -0.1) 
		{
			anim.SetBool ("WalkRight",false);
			anim.SetBool ("Right",false);
			anim.SetBool ("WalkLeft",true);
			anim.SetBool ("Left",true);
		}

		if (GetComponent<Rigidbody2D>().velocity.x < 0 && GetComponent<Rigidbody2D>().velocity.x > 0) 
		{
			anim.SetBool ("WalkRight",false);
			anim.SetBool ("WalkLeft",false);
		
		}
	}
}
