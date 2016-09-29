using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	private LevelManager levelmanager;

	void Start(){
		levelmanager = Object.FindObjectOfType<LevelManager>();
	}

	void OnTriggerEnter2D (Collider2D trig) {
		
		levelmanager.LoadLevel ("Lose Screen");
	}

	void OnCollisionEnter2D (Collision2D col) {
		print ("Collision");
	}
}
