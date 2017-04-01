using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectronFlowScript : MonoBehaviour {

    public GameObject electron;
    // Use this for initialization
    void Start () {
    }
	
    public void createElectrons()
    {
        Debug.Log("Creating Electrons");
        for (int i = 0; i < 40; i++)
        {
            GameObject e = Instantiate(electron);
            e.transform.parent = this.transform;
            e.GetComponent<ElectronScript>().offset = ( 1.000f / 40 ) * i;
        }
    }

    public void destroyElectrons()
    {
        foreach (Transform child in this.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }


	// Update is called once per frame
	void Update () {
		
	}
}
