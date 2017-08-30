﻿using UnityEngine;
using System.Collections;

public class HeadLookUpDown : MonoBehaviour {
	public float velocity = 0.7f;
	public float maxHeight = 20f;

	void Update () {
		float moveY = Camera.main.transform.forward.y * velocity * Time.deltaTime;
		float newY = transform.position.y + moveY;
		if (newY >= 0f && newY < maxHeight) {
			transform.position = new Vector3 (transform.position.x, newY, transform.position.z);
		}
	}
}
