using UnityEngine;
using System.Collections;

public class CreateElecman : MonoBehaviour {

	public float timeBetweenCreation = 3f;
	float time = 0f;
	public float epsilon = 0.5f;
	public int numberObjects = 1;
	public int maxNumberObjects;

	public Vector3 position1 = new Vector3(-15.0f, 9.0f, -15.0f);
	public Vector3 position2 = new Vector3(-12.0f, 9.0f, -10.0f);
	public Vector3 position3 = new Vector3(-14.0f, 9.0f, -6.0f);

	public Vector3 position4 = new Vector3(-15.0f, 9.0f, 11.0f);
	public Vector3 position5 = new Vector3(-12.0f, 9.0f, 15.0f);
	public Vector3 position6 = new Vector3(-14.0f, 9.0f, 19.0f);

	public Vector3 position7 = new Vector3(-15.0f, 12.0f, -15.0f);
	public Vector3 position8 = new Vector3(-12.0f, 12.0f, -12.0f);
	public Vector3 position9 = new Vector3(-14.0f, 12.0f, -8.0f);

	public Vector3 position10 = new Vector3(-15.0f, 12.0f, 11.0f);
	public Vector3 position11 = new Vector3(-12.0f, 12.0f, 15.0f);
	public Vector3 position12 = new Vector3(-14.0f, 12.0f, 19.0f);

	public Vector3 position13 = new Vector3(-15.0f, 10.0f, 2.0f);
	public Vector3 position14 = new Vector3(-12.0f, 10.0f, 6.0f);

	
	public GameObject ElecmanMovePrefab, ShadowManPrefab, target;

	void generateObjects() {
		time = time + Time.deltaTime;
		if (time >= timeBetweenCreation) {

			int pos = Random.Range(1, 15);

			int targetNumber = Random.Range (1,3);


			if (targetNumber == 1) {
				target = ElecmanMovePrefab;
			}
			else {
				target = ShadowManPrefab;
			}

			if(pos == 1){
				GameObject ElecmanMoveObjectPos = 
					Instantiate(target, position1, Quaternion.identity) as GameObject;
			}
				
			else if (pos == 2){
				GameObject ElecmanMoveObjectPos = 
					Instantiate(target, position2, Quaternion.identity) as GameObject;
			}

			else if (pos == 3){
				GameObject ElecmanMoveObjectPos = 
					Instantiate(target, position3, Quaternion.identity) as GameObject;
			}
			else if (pos == 4){
				GameObject ElecmanMoveObjectPos = 
					Instantiate(target, position4, Quaternion.identity) as GameObject;
			}
			
			else if (pos == 5){
				GameObject ElecmanMoveObjectPos = 
					Instantiate(target, position5, Quaternion.identity) as GameObject;
			}
			else if (pos == 6){
				GameObject ElecmanMoveObjectPos = 
					Instantiate(target, position6, Quaternion.identity) as GameObject;
			}
			
			else if (pos == 7){
				GameObject ElecmanMoveObjectPos = 
					Instantiate(target, position7, Quaternion.identity) as GameObject;
			}
			else if (pos == 8){
				GameObject ElecmanMoveObjectPos = 
					Instantiate(target, position8, Quaternion.identity) as GameObject;
			}
			
			else if (pos == 9){
				GameObject ElecmanMoveObjectPos = 
					Instantiate(target, position9, Quaternion.identity) as GameObject;
			}
			else if (pos == 10){
				GameObject ElecmanMoveObjectPos = 
					Instantiate(target, position10, Quaternion.identity) as GameObject;
			}
			
			else if (pos == 11){
				GameObject ElecmanMoveObjectPos3 = 
					Instantiate(target, position11, Quaternion.identity) as GameObject;
			}
			else if (pos == 12){
				GameObject ElecmanMoveObjectPos3 = 
					Instantiate(target, position12, Quaternion.identity) as GameObject;
			}
			else if (pos == 13){
				GameObject ElecmanMoveObjectPos2 = 
					Instantiate(target, position13, Quaternion.identity) as GameObject;
			}
			
			else if (pos == 14){
				GameObject ElecmanMoveObjectPos3 = 
					Instantiate(target, position14, Quaternion.identity) as GameObject;
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
