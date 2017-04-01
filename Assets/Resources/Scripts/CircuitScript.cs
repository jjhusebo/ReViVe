using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircuitScript : MonoBehaviour {
    public Animator circuitAnimator;
    public GameObject lightBulb;
    public GameObject electronFlow;

	// Use this for initialization
	void Start () {
	}
	
    public void turnOn()
    {
        electronFlow.GetComponent<ElectronFlowScript>().createElectrons();
    }

    public void turnOff()
    {
        electronFlow.GetComponent<ElectronFlowScript>().destroyElectrons();
    }
    // Update is called once per frame
    void Update () {
		
	}
}
