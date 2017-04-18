using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityStandardAssets.CrossPlatformInput;

public class Item : MonoBehaviour {
    public bool canPickUp = true;
    public Transform player;
    public float gazeTime = 2f;

    private float timer;
    private bool gazedAt;
    private bool held;

    // Use this for initialization
    void Start() {
        player = GameObject.Find("Player").transform;
        held = false;
    }

    // Update is called once per frame
    void Update() {
        if (gazedAt) {  
            if (CrossPlatformInputManager.GetButtonDown("Interact")) {
                ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerClickHandler);
            }
        }
        else if(transform.parent != null)
        {
            if (CrossPlatformInputManager.GetButtonDown("Interact"))
            {
                transform.parent = null;
                transform.GetComponent<Collider>().enabled = true;
                transform.GetComponent<Rigidbody>().useGravity = true;
                this.gameObject.transform.Find("Tag").gameObject.SetActive(true);
            }
        }
        this.gameObject.transform.Find("Tag").transform.LookAt(Camera.main.transform);
    }

    public void PointerEnter() {
        gazedAt = true;
        this.gameObject.transform.Find("Tag").transform.Find("ObjectName").GetComponent<CanvasRenderer>().SetAlpha(0.3f);
    }

    public void PointerExit() {
        gazedAt = false;
        this.gameObject.transform.Find("Tag").transform.Find("ObjectName").GetComponent<CanvasRenderer>().SetAlpha(1f);
    }

    public void PointerClick() {

        if (player.Find("Main Camera").FindChild("Inventory").childCount == 0) { 
            if (canPickUp) {
                this.gameObject.transform.Find("Tag").gameObject.SetActive(false);
                transform.parent = player.Find("Main Camera").transform.FindChild("Inventory").transform;
                transform.GetComponent<Collider>().enabled = false;
                transform.GetComponent<Rigidbody>().useGravity = false;
                transform.SetPositionAndRotation(transform.parent.position, transform.parent.rotation);
            }
        } else {
            return;
        }
    }
}
