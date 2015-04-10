using UnityEngine;
using System.Collections;

public class CreateElecman : MonoBehaviour {

	public float timeBetweenCreation = 5f;
	float time = 0f;
	public float epsilon = 0.5f;
	public int numberObjects;
	public int maxNumberObjects;

	public float x_min = 1f;
	public float x_max = 30f;
	public float z_min = -19f;
	public float z_max = -8f;
	public float y_max = 10f;
	public float y_min = 4f;

	public GameObject ElecmanMovePrefab;
	public GameObject ElecmanPrefab;

	float x, y, z;

	void generateObjects() {
		time = time + Time.deltaTime;
		if (time >= timeBetweenCreation) {
			
			numberObjects = Random.Range(1, maxNumberObjects);
			
			for (int i = 1; i<= numberObjects; i++) {
				x = Random.Range (x_min, x_max);
				y = Random.Range (y_min, y_max);
				z = Random.Range (z_min, z_max);
				
				GameObject ElecmanMoveObject = 
					Instantiate(ElecmanMovePrefab, new Vector3(x,y,z), Quaternion.identity) as GameObject;
				
				
//				x = Random.Range (x_min, x_max);
//				y = Random.Range (y_min, y_max);
//				z = Random.Range (z_min, z_max);
//				GameObject ElecmanObject = 
//					Instantiate(ElecmanPrefab, new Vector3(x,y,z),  Quaternion.identity) as GameObject;
				
			}
			
			timeBetweenCreation = Random.Range( timeBetweenCreation - epsilon, timeBetweenCreation + epsilon);
			time = 0;
		}
	}

	// Use this for initialization
	void Start () {
		generateObjects();
	}
	
	// Update is called once per frame
	void Update () {
		generateObjects ();
	}
}
