﻿using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	private Paddle paddle ;
	private bool hasStarted = false;
	private Vector3 paddleToBallVector;

	// Use this for initialization
	void Start () {
	paddle = GameObject.FindObjectOfType <Paddle>();
		paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (!hasStarted) {
			this.transform.position = paddle.transform.position + paddleToBallVector;

			if (Input.GetMouseButtonDown (0)) {
				hasStarted = true;
				this.GetComponent<Rigidbody2D>().velocity = new Vector2 (2f,10f);
			}
		}
	}

	void onCollisionEnter2D (Collision2D collision) {
		Vector2 tweek = new Vector2(Random.Range (0f,0.2f),Random.Range (0f,0.2f));
		this.GetComponent <Rigidbody2D>().velocity += tweek;

	}
}
