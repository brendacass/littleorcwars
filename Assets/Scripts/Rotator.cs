using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		Vector3 rotation = new Vector3 (15, 30, 45);
		transform.Rotate (rotation * Time.deltaTime);
	}
}
