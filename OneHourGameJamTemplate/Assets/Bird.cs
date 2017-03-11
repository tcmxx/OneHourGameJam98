using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {


	float speed;
	bool dir;
	float dropDist;
	float distMoved;
	bool dropped;
	public GameObject eggPref;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Vector3.right * (dir ? 1 : -1) * speed * Time.deltaTime;
		distMoved += speed * Time.deltaTime;
		if (distMoved > dropDist && !dropped) {
			Drop ();
		}
	}

	public void StartMove(float speed, bool dir){
		this.speed = speed;
		this.dir = dir;
		distMoved = 0;
		dropped = false;
		dropDist = Random.Range (5.0f, 15.0f);
		Destroy (gameObject, 30/speed);
	}

	private void Drop(){
		dropped = true;
		GameObject.Instantiate (eggPref,transform.position, Quaternion.identity);
	}
}
