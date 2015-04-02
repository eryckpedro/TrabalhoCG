using UnityEngine;
using System.Collections;

public class TargetDestruction : MonoBehaviour {

	void OnCollisionEnter(Collision col)
	{
		Destroy (this.gameObject);
	}
}
