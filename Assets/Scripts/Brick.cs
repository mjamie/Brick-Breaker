﻿using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {


	public int maxHits;
	private int timesHit;
	private LevelManager levelManager;
	// Use this for initialization
	void Start () {
		timesHit = 0;
		levelManager = Object.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		timesHit++;
		if(maxHits >= timesHit){
		Destroy(this.gameObject,0f);
		}
		else if(maxHits == 2){

		}
	}

	//TODO Remove this method once we can actually win
	void SimulateWin(){
		levelManager.LoadNextLevel();
	}
}