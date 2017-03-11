using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pig : MonoBehaviour {


	public Transform initialPos1;
	public Transform initialPos2;
	private Vector3 target;
	private bool moving = false;
	public float lerpT;
	private GameObject curreetEgg;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (moving) {
			transform.position = Vector3.Lerp(transform.position, target, lerpT*Time.deltaTime);
		}
	}



	void OnTriggerEnter2D(Collider2D col){
		if (col.CompareTag ("Egg")) {
			StopAllCoroutines ();
			ObtainEgg (col.gameObject);
		}
	}



	private void ObtainEgg(GameObject egg){
		egg.transform.SetParent (transform);
		curreetEgg = egg;
		egg.GetComponent <Rigidbody2D>().simulated = false;
		StartCoroutine (PigReturnCoroutine());
	}




	public void JumpAt(Vector3 pos){
		if (moving == false) {
			target = pos;
			target.y = transform.position.y;
			target.z = transform.position.z;
			StartCoroutine (PigJumpCoroutine ());
		}

	}


	IEnumerator PigJumpCoroutine(){
		moving = true;
		yield return new WaitForSeconds (3);
		moving = false;
		transform.position = Random.Range (0.0f, 1.0f) > 0.7f ? initialPos2.position : initialPos1.position;
	}

	IEnumerator PigReturnCoroutine(){
		moving = true;
		target = Random.Range (0.0f, 1.0f) > 0.7f ? initialPos2.position : initialPos1.position;
		yield return new WaitForSeconds (3);
		moving = false;
		transform.position = target;
		GameController.Instance.eggsGotten++;
		GameObject.Destroy (curreetEgg);

	}

}
