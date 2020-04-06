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


    [SerializeField] private Text _title = null;
    [SerializeField] private Text _body = null;
    [SerializeField] private GameObject _parent = null;
    [SerializeField] private GameObject _hub = null;

    private void Awake() {
        _eventController = this;
    }

    public void CreateEvent(Event Event) {
        _title.text = Event.title;
        _body.text = Event.body;

        //TODO: TALK TO THE CARD SYSTEM
        _parent.SetActive(true);
    }

    public void PlayCard(CardStats cardStats) {
        //TODO: CHANGE STATS HERE DEPENDING ON WHAT CARD IS PLAYED
        Debug.Log(cardStats.GetStats());
        
        _parent.SetActive(false);
        _hub.SetActive(true);
    }
}
