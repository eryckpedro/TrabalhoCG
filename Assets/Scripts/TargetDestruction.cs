using UnityEngine;
using System.Collections;

public class TargetDestruction : MonoBehaviour {

	public int scoreValue = 10;

	void DestroyGameObject(){
		Destroy(this.gameObject);
	}

	void OnCollisionEnter(Collision col)
	{	

		if(col.gameObject.name == "projectilePrefab(Clone)"){

			ScoreManager.score += scoreValue;

			Destroy(this.renderer);
			Destroy(this.collider);

			audio.Play();

			Invoke("DestroyGameObject", audio.clip.length);


		}

	}

}
