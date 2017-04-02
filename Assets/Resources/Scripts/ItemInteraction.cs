using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityStandardAssets.CrossPlatformInput;

public class ItemInteraction : MonoBehaviour {
    public float gazeTime = 2f;

    private float timer;

    private bool gazedAt;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (gazedAt)
        {
            if (CrossPlatformInputManager.GetButtonDown("Interact"))
            {
                ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
            }
        }
    }

    public void PointerEnter()
    {
        gazedAt = true;
    }

    public void PointerExit()
    {
        gazedAt = false;
    }

    public void PointerDown()
    {
        DestroyObject(gameObject);
    }
}
