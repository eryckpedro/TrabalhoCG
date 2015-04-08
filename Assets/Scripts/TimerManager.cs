using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour {
	
	public static float timer;
	public GameObject gameOver;
	
	Text text;
	
	void Awake (){
		text = GetComponent <Text> ();
		timer = 20.0f;
	}
	
	// Update is called once per frame
	void Update () {
		//text.text = "Score: " + score;
		timer = timer - Time.deltaTime;

		if (timer > 0) {
			text.text = "Tempo: " + timer;
		} else {
			text.text = "Game Over";
		}


	}
}