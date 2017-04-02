using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityStandardAssets.CrossPlatformInput;

public class Item : MonoBehaviour {
    public GameObject item;
    public Sprite icon;
    public bool canPickUp = true;
    public Transform player;
    public float gazeTime = 2f;

    private float timer;
    private bool gazedAt;

    // Use this for initialization
    void Start() {
        player = GameObject.Find("PlayerWithMovement").transform;
    }

    // Update is called once per frame
    void Update() {
        if (gazedAt) {
            if (CrossPlatformInputManager.GetButtonDown("Interact")) {
                ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
            }
        }
    }

    public void PointerEnter() {
        gazedAt = true;
    }

    public void PointerExit() {
        gazedAt = false;
    }

    public void PointerDown() {

        if (player.Find("Main Camera").FindChild("Inventory").childCount == 0) { 
            if (canPickUp) {
                transform.parent = player.Find("Main Camera").FindChild("Inventory").transform;
                transform.GetComponent<Collider>().enabled = false;
                transform.GetComponent<Rigidbody>().useGravity = false;
                transform.SetPositionAndRotation(transform.parent.position, transform.parent.rotation);
            }
        } else {
            return;
        }
    }
}
