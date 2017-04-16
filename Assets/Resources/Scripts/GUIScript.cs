using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class GUIScript : MonoBehaviour {
	public GameObject firstPlayTutorial;
	// Use this for initialization
	void Start () {
		firstPlayTutorial.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		if (CrossPlatformInputManager.GetButtonDown("Horizontal") || CrossPlatformInputManager.GetButtonDown("Vertical") ) {
			firstPlayTutorial.SetActive(false);
		}

	}
}
