using UnityEngine;
using System.Collections;

public class TargetDestruction : MonoBehaviour {

	public int scoreValue = 10;

	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.name == "projectilePrefab(Clone)")
			Destroy (this.gameObject);

		ScoreManager.score += scoreValue;
	}
}
