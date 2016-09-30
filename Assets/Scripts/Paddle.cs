using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public bool autoPlay = false;
	private Ball ball;

	void Start ()
	{
		ball = GameObject.FindObjectOfType <Ball>();
	}

	void Update ()	{
		if (!autoPlay) {
			moveWithMouse ();
		} else {
			
		AutoPlay();

		}
	}

	void AutoPlay(){

		Vector3 ballPos = ball.transform.position;
		Vector3 vec = new Vector3(Mathf.Clamp(ballPos.x,0.5f,15.5f),0.5f,0f);
		this.transform.position = vec;
	}

	void moveWithMouse () {
		float mousePos = Input.mousePosition.x / Screen.width * 16;
		Vector3 vec = new Vector3(Mathf.Clamp(mousePos,0.5f,15.5f),0.5f,0f);
		this.transform.position = vec;
	}
}
