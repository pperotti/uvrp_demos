using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookMoveTo : MonoBehaviour {

	public GameObject ground;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Transform camera = Camera.main.transform;
		Ray ray;
		RaycastHit[] hits;
		GameObject hitObject;

		ray = new Ray (camera.position, camera.rotation * Vector3.forward);

		hits = Physics.RaycastAll (ray);
		for (int i = 0; i < hits.Length; i++) {
			RaycastHit hit = hits [i];
			hitObject = hit.collider.gameObject;
			if (hitObject == ground) {
				Debug.Log ("Hit (x,y,z): " + hit.point.ToString("F2"));
				transform.position = hit.point;
			}
		}

		/*if (Physics.Raycast (ray, out hit)) {
			hitObject = hit.collider.gameObject;
			if (hitObject == ground) {
				Debug.Log ("Hit (x,y,z): " + hit.point.ToString("F2"));
				transform.position = hit.point;
			}
		}*/
	}
}
