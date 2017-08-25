using UnityEngine;
using System.Collections;

public class Trampoline : MonoBehaviour {
	public float bounceForce = 10.0f;

	void OnTriggerEnter( Collider other ) {
		Rigidbody rb = other.GetComponent<Rigidbody> ();
		if (rb != null) {
			rb.AddForce (Vector3.up * bounceForce);
		}
	}
}