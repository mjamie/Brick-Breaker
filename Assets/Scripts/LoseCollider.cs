using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	private LevelManager levelmanager;

	void Start(){
		
		levelmanager = Object.FindObjectOfType<LevelManager>();
	}

	void OnTriggerEnter2D (Collider2D trig) {
		Brick.breakableCount = 0;
		levelmanager.LoadLevel ("Lose Screen");
	}

	void OnCollisionEnter2D (Collision2D col) {
		print ("Collision");
	}
}
