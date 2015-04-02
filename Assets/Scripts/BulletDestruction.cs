using UnityEngine;
using System.Collections;

public class BulletDestruction : MonoBehaviour {

	void OnCollisionEnter(Collision col)
	{
		Destroy (this.gameObject);
	}
}
