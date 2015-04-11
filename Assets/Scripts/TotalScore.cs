using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TotalScore : MonoBehaviour {

	Text text;

	void Awake (){
		text = GetComponent <Text> ();
	}

	// Update is called once per frame
	void Update () {

		text.text = "Score: " + ScoreManager.score;
	
	}
}
