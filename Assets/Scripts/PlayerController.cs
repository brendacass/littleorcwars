using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed = 10;

	void Awake () {
		rigidbody.AddForce (Vector3.up * 500);
		}

	void Update(){

	}
	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical);

		rigidbody.AddForce (movement * speed * Time.deltaTime);
	}
}
