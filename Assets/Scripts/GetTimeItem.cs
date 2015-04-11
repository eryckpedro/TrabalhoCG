using UnityEngine;
using System.Collections;

public class GetTimeItem : MonoBehaviour {

	public float addSeconds = 10.0f;

	void DestroyItem(){
		Destroy(this.gameObject);
	}

	void OnTriggerEnter(Collider col){

		if(col.name == "First Person Controller"){

			TimerManager.timer += addSeconds;

			Destroy (this.renderer);
			Destroy (this.collider);

			audio.Play();

			Invoke("DestroyItem", audio.clip.length);
		}

	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
