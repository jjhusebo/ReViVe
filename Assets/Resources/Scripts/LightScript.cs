using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour {
    public Material lightOff;
    public Material lightOn;
    public Light lightSource;

	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().material = lightOff;
        lightSource.enabled = false;
    }
	
    public void turnOn()
    {
        GetComponent<Renderer>().material = lightOn;
        lightSource.enabled = true;
    }

    public void turnOff()
    {
        GetComponent<Renderer>().material = lightOff;
        lightSource.enabled = false;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
