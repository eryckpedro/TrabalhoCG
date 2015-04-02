using UnityEngine;
using System.Collections;

public class TargetDestruction : MonoBehaviour {

	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.name == "projectilePrefab(Clone)")
			Destroy (this.gameObject);
	}
}
