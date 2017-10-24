using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W_SuperSpeed : MonoBehaviour {

	public float speedBoost = 20;

	void OnTriggerEnter(Collider other) {
		if(other.CompareTag("Player")) {
			Rigidbody rb = other.GetComponent<Rigidbody>();
			rb.AddForce(rb.velocity.normalized * speedBoost, ForceMode.Impulse);
		}
	}
}
