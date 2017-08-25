using UnityEngine;
using System.Collections;

public class HeadLookWalkBounce : MonoBehaviour {
	public float velocity = 0.7f;
	public bool walking = false;

	public float gravity = 9.8f;
	public float bounceForce = 0.0f;

	private CharacterController controller;
	private Clicker clicker = new Clicker();

	private float verticalVelocity = 0.0f;
	private Vector3 moveDirection = Vector3.zero;

	void Start() {
		controller = GetComponent<CharacterController> ();
	}

	void Update () {
		if (clicker.clicked()) {
			walking = !walking;
		}
		if (walking) {
			moveDirection = Camera.main.transform.forward * velocity;
		} else {
			moveDirection = Vector3.zero;
		}
		if (controller.isGrounded) {
			verticalVelocity = 0.0f;
		}
		if (bounceForce != 0.0f) {
			verticalVelocity = bounceForce * 0.02f;
			bounceForce = 0.0f;
		}
		moveDirection.y = verticalVelocity;
		verticalVelocity -= gravity * Time.deltaTime;
		controller.Move (moveDirection * Time.deltaTime);
	}
}