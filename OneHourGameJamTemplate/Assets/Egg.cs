using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnCollisionEnter2D(Collision2D col){
		
		if (col.collider.CompareTag ("Ground")) {
			Lose ();
		}
	}


	public void Lose(){
		GameController.Instance.OnBreakEgg ();
	}
}
