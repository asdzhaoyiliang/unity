using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

	private void OnCollisionEnter(Collision other)
	{
		if (other.transform.tag == "monster")
		{
			SceneManager.LoadScene(0);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if(other.transform.tag == "end")
		{
#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
#else
			Application.Quit();
#endif
		}
	}
}
