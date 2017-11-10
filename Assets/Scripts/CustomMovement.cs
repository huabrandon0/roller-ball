using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class CustomMovement : MonoBehaviour {

	public float speed = 5f;
	public float jumpForce = 5f;

	private bool jump = false;
	private bool isJumping = false;

	Rigidbody rb;
	Animator anim;

	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody>();
		anim = this.GetComponent<Animator>();
	}

	void Update() {
		if (!jump) {
			jump = Input.GetButtonDown("Jump");
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float horiz = Input.GetAxis("Horizontal");
		float vert = Input.GetAxis("Vertical");

		Vector3 movementVec = new Vector3(horiz, 0, vert);
		movementVec.Normalize();
		movementVec *= Time.deltaTime * speed;

		rb.MovePosition(this.transform.position + movementVec);

		if (movementVec != Vector3.zero) {
			Quaternion lookRot = Quaternion.LookRotation(movementVec);
			rb.MoveRotation(lookRot);
		}

		if (movementVec == Vector3.zero) {
			anim.SetBool("Moving", false);
		} else {
			anim.SetBool("Moving", true);
		}

		if (jump && !isJumping) {
			rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
			isJumping = true;
		}

		jump = false;
	}

	void OnCollisionStay(Collision col) {
		foreach (ContactPoint contact in col.contacts) {
			if (contact.normal.y > 0.9f) {
				isJumping = false;
			}
		}
	}
}
