using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Day : MonoBehaviour
{
    test_event_data eventData;
    int DayOfWeek;
    Calendar calendar;
    Week week;

    // Start is called before the first frame update
    void Start()
    {
        calendar = this.GetComponentInParent<Calendar>();
        week = this.GetComponentInParent<Week>();

        //hierdoor luistert hij of er een week voorbij is
        calendar.advanceWeek.AddListener(advanceWeek);


        string dayText = transform.Find("Text").GetComponent<Text>().text;
        switch (dayText)
        {
            case ("Monday"):
                DayOfWeek = 0;
                break;
            case ("Theusday"):
                DayOfWeek = 1;
                break;
            case ("Wednesday"):
                DayOfWeek = 2;
                break;
            case ("Thursday"):
                DayOfWeek = 3;
                break;
            case ("Friday"):
                DayOfWeek = 4;
                break;
            case ("Saturday"):
                DayOfWeek = 5;
                break;
            case ("Sunday"):
                DayOfWeek = 6;
                break;
        }
    }

    void advanceWeek()
    {
        eventData = calendar.GetEventForDay(week.thisWeek + DayOfWeek);
    }
}
