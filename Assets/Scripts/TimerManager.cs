using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour {
	
	public static float timer;
	public GameObject gameOver;
	
	Text text;
	
	void Awake (){
		text = GetComponent <Text> ();
		timer = 120.0f;
	}
	
	// Update is called once per frame
	void Update () {

		timer = timer - Time.deltaTime;

		if (timer > 0) {
			text.text = "Tempo: " + timer.ToString("f1");
		} else {
			text.text = "Game Over";
		}


	}
}