using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public GameObject bulletPrefab;
	public float force = 50.0f;
	public float waitTime = 0.4f;

	private float time;

	// Use this for initialization
	void Start () {
		time = Time.time;
	
	}
	
	// Update is called once per frame
	void Update () {

		float deltaTime = Time.time - time;

		if(Input.GetAxis("Fire1") > 0 && deltaTime > waitTime){
			GameObject bullet = Instantiate(bulletPrefab) as GameObject;
			bullet.transform.position = this.transform.position;
			bullet.rigidbody.AddForce(this.transform.forward*force);

			time = Time.time;

			audio.Play();
		}
	
	}
}
