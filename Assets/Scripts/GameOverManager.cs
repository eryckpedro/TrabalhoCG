using UnityEngine;
using System.Collections;

public class GameOverManager : MonoBehaviour {
	
	public GameObject bulletPrefab;

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetAxis("Fire1") > 0){
			Destroy(this.gameObject);
		}
		
	}
}