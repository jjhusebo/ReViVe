using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineScript : MonoBehaviour {

    public GameObject circuit;

	// Use this for initialization
	void Start () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Battery")
        {
            Debug.Log("Battery on trigger!");
            circuit.GetComponent<CircuitScript>().turnOn();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.name == "Battery")
        {
            Debug.Log("Battery removed!");
            circuit.GetComponent<CircuitScript>().turnOff();
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
