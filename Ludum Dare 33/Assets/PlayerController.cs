﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private Rigidbody2D rb;
	private bool movingRight;
	private bool movingLeft;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		movingRight = false;
		movingLeft = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			movingLeft = false;
			movingRight = true;
		}
		if (Input.GetKeyUp(KeyCode.RightArrow)) {
			movingRight = false;
		}
		if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			movingRight = false;
			movingLeft = true;
		}
		if (Input.GetKeyUp(KeyCode.LeftArrow)) {
			movingLeft = false;
		}

		if (Input.GetKeyDown(KeyCode.Space)) {
			rb.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (movingRight) {
			rb.AddForce(Vector2.right * 10);
		}
		if (movingLeft) {
			rb.AddForce(Vector2.left * 10);
		}
	}
}
