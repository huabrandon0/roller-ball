using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W_Rotator : MonoBehaviour {
	public Vector3 rotateAngle;

	void Update() {
		this.transform.Rotate(rotateAngle * Time.deltaTime);
	}
}
