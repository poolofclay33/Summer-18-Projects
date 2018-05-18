using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2D : MonoBehaviour {

	private float x;
	private float y;
	public float moveSpeed;

	void FixedUpdate() {
		x = Input.GetAxis ("Horizontal");
		y = Input.GetAxis ("Vertical");

		GetComponent<Rigidbody2D> ().velocity = new Vector2 (x * moveSpeed, y * moveSpeed);
	}
}
