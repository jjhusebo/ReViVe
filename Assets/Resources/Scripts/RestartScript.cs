using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class RestartScript : MonoBehaviour {
	public string levelToLoad;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(CrossPlatformInputManager.GetButtonDown("Restart"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(levelToLoad);
        }
	}
}
