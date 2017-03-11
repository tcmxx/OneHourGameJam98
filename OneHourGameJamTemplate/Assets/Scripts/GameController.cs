using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public static GameController Instance;

	public int eggsGotten;
	public GameObject birdPref;
	public Transform birdPos1;
	public Transform birdPos2;

	void Awake(){
		Instance = this;
	}

	// Use this for initialization
	void Start () {
		Initialize ();
		SpawnBird ();
	}
	// Update is called once per frame
	void Update () {
		
	}


	public void OnObtainEgg(){
		eggsGotten++;
	}
	public void OnBreakEgg(){
		GamePlayUI.gamePlayUI.ShowGameOver ();
	}



	void Initialize(){
		eggsGotten = 0;
	}



	void SpawnBird(){
		bool dir = Random.Range (0.0f, 1.0f) > 0.6f;
		Vector3 pos = dir?birdPos1.position:birdPos2.position;
		Bird b = GameObject.Instantiate (birdPref,pos, Quaternion.identity).GetComponent <Bird>();
		b.StartMove (4,!dir);
		if (eggsGotten < 10) {
			Invoke ("SpawnBird", 6.0f);
		} else if (eggsGotten < 20) {
			Invoke ("SpawnBird", 5.0f);
		} else {
			Invoke ("SpawnBird", 4.0f);
		}
	}



}
