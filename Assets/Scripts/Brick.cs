using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {


	public AudioClip pop;
	public static int breakableCount = 0;
	public Sprite[] hitsSprite;

	private int timesHit;
	private LevelManager levelManager;
	private bool isBreakable;

	// Use this for initialization
	void Start () {
		isBreakable = (this.tag == "Breakable");
		timesHit = 0;
		if(isBreakable){
			breakableCount++;
			print (breakableCount);
		}
		levelManager = Object.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D col){
		AudioSource.PlayClipAtPoint (pop,transform.position);
		if (isBreakable) {
			HandleHits ();
		}
	}


	void HandleHits(){
		timesHit++;
		int maxHits = hitsSprite.Length + 1;
		if (maxHits <= timesHit) {
			
			breakableCount--;
			levelManager.brickDestroyed ();
			print (breakableCount);

			Destroy (this.gameObject, 0f);

		} else {
			LoadSprites ();

		}
		}

	void LoadSprites ()
	{
		int spriteIndex = timesHit - 1;
		if (hitsSprite [spriteIndex]) {
			this.GetComponent<SpriteRenderer> ().sprite = hitsSprite [spriteIndex];
		}
	}

	//TODO Remove this method once we can actually win
	void SimulateWin(){
		levelManager.LoadNextLevel();
	}
}
