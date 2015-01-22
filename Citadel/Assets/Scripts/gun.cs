using UnityEngine;
using System.Collections;

public class gun : MonoBehaviour 
{
	public GameObject shootobj;
	public Transform FP;
	public Transform FP2;
	public float speed;
	public float clip=6;
	public float maxCLIP=84;

	private float axisInput;
	
	// Update is called once per frame
	void Update () 
	{
		if( Input.GetButtonDown ("Fire1") )

		//if(Input.GetAxis(3 rightrigger))
		   {
			if (clip > 0)
			{
			clip --;
			GameObject projectile= Instantiate(shootobj,FP.position,FP.rotation)as GameObject;
			projectile.rigidbody2D.velocity=new Vector2(0,speed);

			GameObject projectile2= Instantiate(shootobj,FP2.position,FP2.rotation)as GameObject;
			projectile2.rigidbody2D.velocity=new Vector2(0,speed);
			}

				
		}
		if( Input.GetButtonDown ("Fire2")) 
		{
			clip = 6;
		}
	}
	void OnGUI ()
	{
		GUI.color = Color.black;
		GUI.Label (new Rect( Screen.width -110,10, 100, 40), "clip:" + (int)clip +"/"+ maxCLIP);
		if (clip <=0)
		{
			GUI.Label(new Rect( Screen.width -110, 40, 100, 40), "Reload, Press X/RMB" );
		}

	}


}


	
	