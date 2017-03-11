using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamePlayUI : MonoBehaviour {
	public static GamePlayUI gamePlayUI;

	public Text scoreText;
	public GameObject gameOverPanel;
	public Text endGameSCoreText;
	void Awake(){
		gamePlayUI = this;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Eggs: " + GameController.Instance.eggsGotten;
	}



	public void Restart(){
		SceneManager.LoadScene ("GameScene");
	}

	public void Quit(){
		SceneManager.LoadScene ("MenuScene");
	}

	public void ShowGameOver(){
		gameOverPanel.SetActive (true);
		endGameSCoreText.text = "Total Eggs: " + GameController.Instance.eggsGotten;
	}
}
