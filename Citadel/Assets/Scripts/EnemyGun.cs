using UnityEngine;
using System.Collections;


public class EnemyGun : MonoBehaviour
{
	public GameObject shootobj;
	public GameObject target;
	public float attackrange=10;

	public float FireTime = 1;
	public float LastFireTime;
	public float speed;
	public Transform FP;
	public Transform FP2;
	
	// Update is called once per frame
	void Update () 
	{
		
		if( Time.time > FireTime+LastFireTime )
		{
			if(Vector2.Distance(transform.position, target.transform.position)<attackrange)
			{
				
				LastFireTime = Time.time;
				GameObject projectile= Instantiate(shootobj,FP.position,FP.rotation)as GameObject;
				GameObject projectile2= Instantiate(shootobj,FP2.position,FP2.rotation)as GameObject;
				projectile.rigidbody2D.velocity=new Vector2(0,speed);
				projectile2.rigidbody2D.velocity=new Vector2(0,speed);
			}
		}
		
	}
}

