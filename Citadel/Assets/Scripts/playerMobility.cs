﻿using UnityEngine;
using System.Collections;

public class playerMobility : MonoBehaviour {


	public Vector2 speed = new Vector2 (5, 5);
	private Vector2 movement;

	void Start ()

	{

		}


	void Update () 
	{
		float inputX = Input.GetAxis ("Horizontal");
		float inputY = Input.GetAxis ("Vertical");

		movement = new Vector2(speed.x * inputX, speed.y * inputY);
	}

	void FixedUpdate () 
	{
		rigidbody2D.velocity = movement;
	}






}
