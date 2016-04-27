using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

/// <summary>
/// Author: Matt Gipson
/// Contact: Deadwynn@gmail.com
/// Domain: www.livingvalkyrie.net
/// 
/// Description: CharacterMovement 
/// </summary>
public class CharacterMovement : MonoBehaviour {

	#region Fields

	Rigidbody2D rb2D;
	bool facingRight;
	public float speed = 4;
	Animator anim;

	#endregion
	
	void Start () {
		rb2D = GetComponent<Rigidbody2D>();
		anim = GetComponentInChildren<Animator>();
	}
	
	void Update () {
		//TODO add touch controls

		float movementPlayerVector = Input.GetAxis("Horizontal");

		rb2D.velocity = new Vector2(movementPlayerVector * speed, rb2D.velocity.y);
		anim.SetFloat("Speed", Mathf.Abs(movementPlayerVector));

		if (movementPlayerVector > 0 && !facingRight) {
			Flip();
		}else if (movementPlayerVector < 0 && facingRight) {
			Flip();
		}

	}

	void Flip() {
		facingRight = !facingRight;

		Vector3 playerScale = transform.localScale;
		playerScale.x *= -1;
		transform.localScale = playerScale;
	}
}

