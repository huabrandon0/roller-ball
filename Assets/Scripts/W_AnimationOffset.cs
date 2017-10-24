using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W_AnimationOffset : MonoBehaviour {

	[Range(0, 1)]
	public float startOffset;

	private Animator anim;

	void Start() {
		anim = GetComponentInChildren<Animator>();
		if(anim == null) {
			Debug.LogError("No Animator found on GameObject, you should add one from the Inspector");
		}
		else {
			anim.Play(anim.GetCurrentAnimatorStateInfo(0).shortNameHash, 0, startOffset);
		}
	}
}
