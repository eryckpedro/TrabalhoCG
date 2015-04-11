using UnityEngine;
using System.Collections;

public class GameOverManager : MonoBehaviour {
	
	public GameObject bulletPrefab;

	public float restartDelay = 5.0f;
	private float restartTimer;

	
	// Use this for initialization
	void Start () {
		restartTimer = 0.0f;
	}

	
	// Update is called once per frame
	void Update () {

		restartTimer += Time.deltaTime;

		if(restartTimer >= restartDelay){

			Application.LoadLevel("Main");
		}

	}
}