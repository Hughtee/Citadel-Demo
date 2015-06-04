using UnityEngine;
using System.Collections;

public class playerAnimation : MonoBehaviour {



	public Animator anim;
	const float coolDown = 0.5f;
	public float timer = 0.0f;

	public bool handleTouch;
	public bool up_key;
	public bool down_key;
	public bool left_key;
	public bool right_key;
	public bool attack_key;
	public AudioClip slashSound;
	private AudioSource Source;
	private float volLowRange= .5f;
	private float volHighRange= 1.0f;
	public AudioClip stepSound;
	private AudioSource sources;


	void Start () 
	{
		Source = GetComponent<AudioSource>();
		anim = GetComponent<Animator>();
		sources = GetComponent<AudioSource>();
	}
	
	void UpdateTimer ()
	{
		timer -= Time.deltaTime;
	}

	void Update () 
	{
		UpdateTimer ();

			if ( (Input.GetMouseButtonDown (0) && !handleTouch) || 
			    ( handleTouch && attack_key ) ) {

				if (timer <= 0.0f) {
					anim.SetBool ("Attack", true);
					Source.PlayOneShot(slashSound,.5F);
				    Debug.Log ("Attack = true");
					timer = coolDown;
				}
			} else {
				anim.SetBool ("Attack", false);
			}
		

		if (Input.GetKey (KeyCode.A) || left_key) 
		{
			anim.SetBool ("Left",true);
			anim.SetBool ("Down",false);
			anim.SetBool ("Right",false);
			anim.SetBool ("Up",false);
			sources.PlayOneShot(stepSound,.0F);


		}
		if (Input.GetKey (KeyCode.S) || down_key) 
		{
			anim.SetBool ("Left",false);
			anim.SetBool ("Down",true);
			anim.SetBool ("Right",false);
			anim.SetBool ("Up",false);
			sources.PlayOneShot(stepSound,.0F);
		

		}
		if (Input.GetKey (KeyCode.D) || right_key) 
		{
			anim.SetBool ("Left",false);
			anim.SetBool ("Down",false);
			anim.SetBool ("Right",true);
			anim.SetBool ("Up",false);
			sources.PlayOneShot(stepSound,.0F);
	

		}
		if (Input.GetKey (KeyCode.W) || up_key) 
		{
			anim.SetBool ("Left",false);
			anim.SetBool ("Down",false);
			anim.SetBool ("Right",false);
			anim.SetBool ("Up",true);
			sources.PlayOneShot(stepSound,.0F);
		

		}
		if (Input.GetKey(KeyCode.W) || up_key) 
		{
			anim.SetBool ("WalkUp", true);
		} 
		else 
		{
			anim.SetBool ("WalkUp", false);
		}
		if (Input.GetKey(KeyCode.A) || left_key) 
		{
			anim.SetBool ("WalkLeft", true);
		} 
		else 
		{
			anim.SetBool ("WalkLeft", false);
		}
		if (Input.GetKey(KeyCode.D) || right_key) 
		{
			anim.SetBool ("WalkRight", true);
		} 
		else {
			anim.SetBool ("WalkRight", false);
		}
		if (Input.GetKey(KeyCode.S) || down_key) 
		{
			anim.SetBool ("WalkDown", true);
		} 
		else 
		{
			anim.SetBool ("WalkDown", false);
		}
	}

}
