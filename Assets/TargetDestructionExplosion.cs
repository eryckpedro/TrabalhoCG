using UnityEngine;
using System.Collections;

public class TargetDestructionExplosion : MonoBehaviour {
	
	public int scoreValue = 10;
	public Component particleSystemObject;
	
	
	void DestroyGameObject(){
		Destroy(this.gameObject);
	}
	
	void OnCollisionEnter(Collision col)
	{	
		
		if(col.gameObject.name == "projectilePrefab(Clone)"){
			
			this.particleSystem.enableEmission = true;
			//particleSystem.enableEmission = true;
			
			ScoreManager.score += scoreValue;
			
			Destroy(this.renderer);
			Destroy(this.collider);
			
			audio.Play();
			
			Invoke("DestroyGameObject", audio.clip.length);
			
			
		}
		
	}
	
}