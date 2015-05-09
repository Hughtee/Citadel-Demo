using UnityEngine;
using System.Collections;

public class playerAnimation : MonoBehaviour {



	public Animator anim;
	const float coolDown = 0.5f;
	public float timer = 0.0f;


	void Start () 
	{
		anim = GetComponent<Animator>();
	}
	
	void UpdateTimer ()
	{
		timer -= Time.deltaTime;
	}

	void Update () 
	{
		UpdateTimer ();
		if (Input.GetMouseButtonDown(0))
		{
			if (timer <= 0.0f)
			{
				anim.SetBool ("Attack", true);
				timer = coolDown;
			}
		}
		else
		{
			anim.SetBool ("Attack", false);
		}

		if (Input.GetKey (KeyCode.A)) 
		{
			anim.SetBool ("Left",true);
			anim.SetBool ("Down",false);
			anim.SetBool ("Right",false);
			anim.SetBool ("Up",false);
		}
		if (Input.GetKey (KeyCode.S)) 
		{
			anim.SetBool ("Left",false);
			anim.SetBool ("Down",true);
			anim.SetBool ("Right",false);
			anim.SetBool ("Up",false);
		}
		if (Input.GetKey (KeyCode.D)) 
		{
			anim.SetBool ("Left",false);
			anim.SetBool ("Down",false);
			anim.SetBool ("Right",true);
			anim.SetBool ("Up",false);
		}
		if (Input.GetKey (KeyCode.W)) 
		{
			anim.SetBool ("Left",false);
			anim.SetBool ("Down",false);
			anim.SetBool ("Right",false);
			anim.SetBool ("Up",true);
		}
		if (Input.GetKey(KeyCode.W)) 
		{
				anim.SetBool ("WalkUp", true);
		} 
		else 
		{
			anim.SetBool ("WalkUp", false);
		}
		if (Input.GetKey(KeyCode.A)) 
		{
			anim.SetBool ("WalkLeft", true);
		} 
		else 
		{
			anim.SetBool ("WalkLeft", false);
		}
		if (Input.GetKey(KeyCode.D)) 
		{
			anim.SetBool ("WalkRight", true);
		} 
		else {
			anim.SetBool ("WalkRight", false);
		}
		if (Input.GetKey(KeyCode.S)) 
		{
			anim.SetBool ("WalkDown", true);
		} 
		else 
		{
			anim.SetBool ("WalkDown", false);
		}
	}
}
