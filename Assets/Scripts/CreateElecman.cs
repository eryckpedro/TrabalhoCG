using UnityEngine;
using System.Collections;

public class CreateElecman : MonoBehaviour {

	public float timeBetweenCreation = 5f;
	float time = 0f;
	public float epsilon = 0.5f;
	public int numberObjects = 1;
	public int maxNumberObjects;

	public Vector3 position1 = new Vector3(-15.0f, 9.0f, -15.0f);
	public Vector3 position2 = new Vector3(-12.0f, 9.0f, -12.0f);
	public Vector3 position3 = new Vector3(-14.0f, 9.0f, -8.0f);

	
	public GameObject ElecmanMovePrefab;

	float x, y, z;

	void generateObjects() {
		time = time + Time.deltaTime;
		if (time >= timeBetweenCreation) {

			int pos = Random.Range(1, 3);

			if(pos == 1){
				GameObject ElecmanMoveObjectPos1 = 
					Instantiate(ElecmanMovePrefab, position1, Quaternion.identity) as GameObject;
			}
				
			else if (pos == 2){
				GameObject ElecmanMoveObjectPos2 = 
					Instantiate(ElecmanMovePrefab, position2, Quaternion.identity) as GameObject;
			}

			else if (pos == 3){
				GameObject ElecmanMoveObjectPos3 = 
					Instantiate(ElecmanMovePrefab, position3, Quaternion.identity) as GameObject;
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
