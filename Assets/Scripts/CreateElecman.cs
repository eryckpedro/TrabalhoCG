using UnityEngine;
using System.Collections;

public class CreateElecman : MonoBehaviour {

	public float timeBetweenCreation = 5f;
	float time = 0f;
	public float epsilon = 0.5f;
	public int numberObjects;
	public int maxNumberObjects = 1;

	public float x_min = 1f;
	public float x_max = 30f;
	public float z_min = -19f;
	public float z_max = 30f;
	public float y = 20f;

	public GameObject ElecmanMovePrefab;
	public GameObject ElecmanPrefab;
	public GameObject ElecmanSpherePrefab;

	float x, z;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		time = time + Time.deltaTime;
		if (time >= timeBetweenCreation) {

			numberObjects = Random.Range(1, maxNumberObjects);

			for (int i = 1; i<= numberObjects; i++) {
				x = Random.Range (x_min, x_max);
				z = Random.Range (z_min, z_max);

				GameObject ElecmanMoveObject = Instantiate(ElecmanMovePrefab, new Vector3(x,y,z), Quaternion.identity) as GameObject;

				x = Random.Range (x_min, x_max);
				z = Random.Range (z_min, z_max);
				GameObject ElecmanObject = Instantiate(ElecmanPrefab, new Vector3(x,y,z),  Quaternion.identity) as GameObject;

				x = Random.Range (x_min, x_max);
				z = Random.Range (z_min, z_max);
				GameObject ElecmanSphereObject = Instantiate(ElecmanSpherePrefab, new Vector3(x,y,z), Quaternion.identity) as GameObject;
			
			}

			timeBetweenCreation = Random.Range( timeBetweenCreation - epsilon, timeBetweenCreation + epsilon);
			time = 0;
		}
	}
}
