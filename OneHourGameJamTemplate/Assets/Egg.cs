﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour {

	public SpriteRenderer rend;
	public Sprite spriteBroken;
	public Sprite spriteNormal;
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
		rend.sprite = spriteBroken;
		GetComponent <CircleCollider2D>().enabled = false;
		GetComponent <Rigidbody2D> ().simulated = false;
		GameController.Instance.OnBreakEgg ();
	}
}
