using UnityEngine;
using System.Collections;

public class ElecmanMovement : MonoBehaviour {

	// Use this for initialization

	public float power = 0.000000001f;
	public int waitTime = 1;
	float time = 0f;

	void Start () {
		this.rigidbody.AddForce (new Vector3(15,0,0));
	}
	
	// Update is called once per frame
	void Update () {
		time = time + Time.deltaTime;
		if (time > waitTime) {
			var randomPosition = new Vector3 (Random.Range( -200,200), Random.Range( -200,200), Random.Range( -200,200));
			this.rigidbody.AddForce(randomPosition, ForceMode.Force);
			time = 0;
		}
	}
}
