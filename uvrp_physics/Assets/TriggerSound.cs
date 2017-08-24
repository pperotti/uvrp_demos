using System.Collections;
using UnityEngine;

public class TriggerSound : MonoBehaviour {

	public AudioClip hitSound;

	AudioSource aa;

	// Use this for initialization
	void Start () {
		aa = GetComponent < AudioSource> ();
	}

	void OnTriggerEnter(Collider other) {
		aa.Play ();
	}
}
