using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayUI : MonoBehaviour {
	public static GamePlayUI gamePlayUI;

	void Awake(){
		gamePlayUI = this;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



	public void Restart(){
		SceneManager.LoadScene ("GameScene");
	}

	public void Quit(){
		SceneManager.LoadScene ("MenuScene");
	}
}
