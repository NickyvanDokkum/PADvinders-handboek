using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventController : MonoBehaviour
{
    public static EventController eventController {
        get { return _eventController; }
    }
    private static EventController _eventController;


    [SerializeField] private Text _title;
    [SerializeField] private Text _body;
    [SerializeField] private GameObject _parent;
    [SerializeField] private GameObject _hub;

    private void Awake() {
        _eventController = this;
    }

    public void CreateEvent(Event Event) {
        _title.text = Event.title;
        _body.text = Event.body;

        //TODO: TALK TO THE CARD SYSTEM

        _parent.SetActive(true);
    }

    public void PlayCard(/*TODO: PUT CARD HERE*/) {
        //TODO: CHANGE STATS HERE DEPENDING ON WHAT CARD IS PLAYED

        _parent.SetActive(false);
        _hub.SetActive(true);
    }
}
