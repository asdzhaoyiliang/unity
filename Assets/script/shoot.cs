using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {
	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;

	private Vector3 moveDirection = Vector3.zero;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		var x = Input.GetAxis("Horizontal");
		var z = Input.GetAxis("Vertical");
		// transform.Translate(x,0,z);

		// if (Input.GetKey(KeyCode.Space))
		// {
		// 	
		// 	transform.Translate(0,Time.deltaTime*50,0);
		// }
		// if (Input.GetKey(KeyCode.V))
		// {
		// 	transform.Translate(0,-Time.deltaTime*50,0);
		// }
		
		CharacterController controller = GetComponent<CharacterController>();
		if (controller.isGrounded) {
			moveDirection = new Vector3(x, 0, z);
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;
			if (Input.GetKey(KeyCode.V))
				moveDirection.y = jumpSpeed;
		}
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);


	}
}
