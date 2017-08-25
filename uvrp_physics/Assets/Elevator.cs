using UnityEngine;
using System.Collections;

public class Elevator : MonoBehaviour {
	public float minHeight = 1.2f;
	public float maxHeight = 8.0f;
	public float velocity = 1;

	void Update () {
		float y = transform.position.y;
		y += velocity * Time.deltaTime;
		if (y > maxHeight) {
			y = maxHeight;
			velocity = -velocity;
		}
		if (y < minHeight) {
			y = minHeight;
			velocity = -velocity;
		}
		transform.position = new Vector3 (transform.position.x, y, transform.position.z);
	}
}
