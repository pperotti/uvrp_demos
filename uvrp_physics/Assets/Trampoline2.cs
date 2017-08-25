using UnityEngine;
using System.Collections;

public class Trampoline2 : MonoBehaviour {
	public float bounceForce = 300.0f;

	void OnTriggerEnter( Collider other ) {
		Rigidbody rb = other.GetComponent<Rigidbody> ();
		if (rb != null) {
			rb.AddForce (Vector3.up * bounceForce);
		} else {
			HeadLookWalkBounce locomotor = other.GetComponent<HeadLookWalkBounce> ();
			if (locomotor != null) {
				locomotor.bounceForce = bounceForce;
			}
		}
	}
}
