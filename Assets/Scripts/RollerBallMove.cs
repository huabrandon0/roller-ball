using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollerBallMove : MonoBehaviour {

	public float speed = 5f;

	void FixedUpdate() {
		float horizontal, vertical;

		horizontal = Input.GetAxisRaw("Horizontal");
		vertical = Input.GetAxisRaw("Vertical");

		Vector3 force = new Vector3(horizontal, 0f, vertical);
		this.GetComponent<Rigidbody>().AddForce(force * speed);
	}
}
