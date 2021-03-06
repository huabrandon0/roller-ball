﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W_SuperJump : MonoBehaviour {

	public float jumpPower = 13f;

	void OnTriggerEnter(Collider other) {
		if(other.CompareTag("Player")) {
			Rigidbody rb = other.GetComponent<Rigidbody>();
			rb.AddForce(Vector3.up * jumpPower, ForceMode.VelocityChange);
		}
	}
}
