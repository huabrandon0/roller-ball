using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W_TeleportZone : MonoBehaviour {

	public Transform teleportPoint;

	void OnTriggerEnter(Collider other) {
		if(other.CompareTag("Player")) {
			if(teleportPoint != null) {
				other.transform.position = teleportPoint.position;
				Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
				rb.Sleep();
			}
			else {
				Debug.LogError("Cannot find \"Teleport Point\". " +
					"You probably need to drag it into the Inspector.");
			}
		}
	}
}
