using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class man : MonoBehaviour {
	public float speed = 6.0F;
	public float gravity = 150.0F;

	private Vector3 move;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		var x = Input.GetAxis("Horizontal");
		var z = Input.GetAxis("Vertical");

		CharacterController player = GetComponent<CharacterController>();
		move = new Vector3(x, 0, z);
		move = transform.TransformDirection(move);
		move *= speed;

		move.y -= gravity * Time.deltaTime ;
		player.Move(move * Time.deltaTime);

	}
	
}
