using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEventScript : MonoBehaviour
{
    public void ActivateNewEvent() {
        EventController.eventController.CreateEvent(new Event("New Title", "This is the new test body"));
        this.gameObject.SetActive(false);
    }
}
