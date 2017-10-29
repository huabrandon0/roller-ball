using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W_SceneSwitchZone : MonoBehaviour {

	public string nextSceneName = "";

	W_SceneSwitcher switcher;

	void Start() {
		switcher = GetComponent<W_SceneSwitcher>();
	}

	void OnCollisionEnter() {
		switcher.SwitchScene(nextSceneName);
	}
}
