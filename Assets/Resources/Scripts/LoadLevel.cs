using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour {
    public string levelToLoad;

	// Use this for initialization
	void Start () {
		
	}
	
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(levelToLoad);
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}
