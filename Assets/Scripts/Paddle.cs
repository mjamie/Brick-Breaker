using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		float mousePos = Input.mousePosition.x / Screen.width * 16;
		Vector3 vec = new Vector3(Mathf.Clamp(mousePos,0.5f,15.5f),0.5f,0f);
		this.transform.position = vec;
	}
}
