using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolvePuzzleScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }
    void OnTriggerStay(Collider other)
    {
        if (other.name == "Battery")
        {
            other.gameObject.transform.position = new Vector3(-6.735f, 1.72f, -4.184f);
            other.gameObject.transform.eulerAngles = new Vector3(0, 0, 180);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
