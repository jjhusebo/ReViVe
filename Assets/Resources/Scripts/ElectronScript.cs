using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectronScript : MonoBehaviour {

    Animator animator;
    public float offset;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        animator.Play("Electron", -1, offset);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
