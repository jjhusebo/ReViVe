using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour {

    private Animator animator;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        Debug.Log("Script ran!");
    }
	
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collider");
        if (other.tag == "Player")
        {
            animator.SetBool("open", true);
        }
    }

	// Update is called once per frame
	void Update () {
    }
}
