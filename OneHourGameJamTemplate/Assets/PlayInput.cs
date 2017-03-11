using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayInput : MonoBehaviour {
	public Pig controlPlayer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			controlPlayer.JumpAt (Camera.main.ScreenToWorldPoint (Input.mousePosition));
		}
	}
}
