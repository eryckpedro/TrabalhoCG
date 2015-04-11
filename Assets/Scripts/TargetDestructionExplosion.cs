using UnityEngine;
using System.Collections;

public class TargetDestructionExplosion : MonoBehaviour {
	
	public int scoreValue = 30;
	public GameObject particleSystemPrefab;
	
	
	void DestroyGameObject(){
		Destroy(this.gameObject);
	}
	
	void OnCollisionEnter(Collision col)
	{	
		 
		if(col.gameObject.name == "projectilePrefab(Clone)"){

			GameObject particleSystemObject = Instantiate(particleSystemPrefab, this.transform.position, Quaternion.identity) as GameObject;
			particleSystemObject.particleSystem.enableEmission = true;


			ScoreManager.score += scoreValue;
			
			Destroy(this.renderer);
			Destroy(this.collider);
			
			audio.Play();
			
			Invoke("DestroyGameObject", audio.clip.length);
			
			
		}
		
	}
	
}