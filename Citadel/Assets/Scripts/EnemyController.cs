﻿using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{


	public GameObject player;
	public float attackRange;
	public Transform firePoint;
	public GameObject projectile;
	public float fireRate;
	private float nextFire;


	// Use this for initialization
	void Start ()
	{
		{
		if (GetComponent<Rigidbody> ()) 
			{
			 GetComponent<Rigidbody> ().freezeRotation = true;
			}

		}
	}
	
	// Update is called once per frame
	void Update ()
	{
	
		if (player) 
		{
			if (attackRange > Vector3.Distance (player.transform.position, transform.position) ) 
			{
				Debug.Log ( "Within Range!" + Vector3.Distance (player.transform.position, transform.position));
				if (Time.time > nextFire) 
				{
					nextFire = Time.time + fireRate;

					GameObject bullet = Instantiate (projectile, firePoint.position, firePoint.rotation) as GameObject;
				
					bullet.GetComponent<Projectile> () .CreatedBy ("Enemy03");
				}

			} else 
			{
				Debug.Log ( Vector3.Distance (player.transform.position, transform.position) );
			}
		
		} 
		else 
		{
			player = GameObject.FindGameObjectWithTag ("Player");
			
		}
	}


}