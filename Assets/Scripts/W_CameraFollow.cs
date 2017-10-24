using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W_CameraFollow : MonoBehaviour {

	public Transform ball;

	private Vector3 offset;

	void Start() {
		if(ball != null) {
			offset = transform.position - ball.position;
		}
		else {
			Debug.LogError("Cannont find reference to \"Ball\". " +
				"You probably need to drag it into the Inspector.");
		}
	}

	void Update() {
		transform.position = ball.position + offset;
	}
}
