using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour {

    private Animator animator;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
    }

    public void openDoor()
    {
            animator.SetBool("open", true);
    }

	// Update is called once per frame
	void Update () {
    }
}
