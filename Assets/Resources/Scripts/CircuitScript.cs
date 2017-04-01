using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircuitScript : MonoBehaviour {
    public Animator circuitAnimator;
    public GameObject lightBulb;
    public GameObject electronFlow;
    public GameObject door;

	// Use this for initialization
	void Start () {
	}
	
    public void turnOn()
    {
        electronFlow.GetComponent<ElectronFlowScript>().createElectrons();
        lightBulb.GetComponent<LightScript>().turnOn();
        door.GetComponent<OpenDoor>().openDoor();
    }

    public void turnOff()
    {
        electronFlow.GetComponent<ElectronFlowScript>().destroyElectrons();
        lightBulb.GetComponent<LightScript>().turnOff();
    }
    // Update is called once per frame
    void Update () {
		
	}
}
