using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Calendar : MonoBehaviour
{
    List<DayInformation> plannedDays;
    public int currentDay;
    public test_event_data todaysEvent;

    // hierdoor kunnen de scripten van de weeken meeluisteren of er een week voorbij is
    public UnityEvent advanceWeek;

    // Start is called before the first frame update
    public void Start()
    {
        currentDay = 1;
        plannedDays = new List<DayInformation>();

        // dit is om te testen
        FillMonth(1);
        FillMonth(28);
    }

    public void AdvanceDay()
    //elke dag is er ook nog een structured event maar daar hoef ik niks mee te doen
    {

        currentDay++;

        //check of de week is afgelopen om vervolgens de huur te betalen
        if (0 == currentDay % 8)
        {
            advanceWeek.Invoke();
            //betaal de huur

            int deletedDays = 0;
            //verwijder de dingen uit de list van de vorige week
            for (int index = plannedDays.Count - 1; index >= 0; index--)
            {
                DayInformation plannedDay = plannedDays[index];

                if (plannedDay.day < currentDay)
                {
                    deletedDays++;
                    plannedDays.Remove(plannedDay);

                    if(deletedDays == 7)
                    {
                        break;
                    }

                }
            }

        }

        //check of er event zijn ingepland voor de volgende dag
        foreach (DayInformation plannedDay in plannedDays)
        {
            if (plannedDay.day == currentDay)
            {
                todaysEvent = plannedDay.cardEvent;
                break;
            }
            else
            {
                // er is geen event geplanned voor vandaag
                todaysEvent = null;
            }
        }
    }

    //nog niet getest
    public test_event_data GetEventForDay(int day)
    {
        foreach (DayInformation plannedDay in plannedDays)
        {
            if(plannedDay.day == day)
            {
                return plannedDay.cardEvent;
            }
        }
        
        return null;
    }

    public void PlanEvent(int day, test_event_data cardEvent)
    {
        plannedDays.Add(new DayInformation(day, cardEvent));
    }

    class DayInformation
    {
        public int day;
        public test_event_data cardEvent;

        // hier moet ook het event worden opgeslagen

        public DayInformation(int day, test_event_data cardEvent)
        {
            this.day = day;
            this.cardEvent = cardEvent;
        }
    }

    // dit is alleen om te testen
    public void FillMonth(int startWeek)
    {
        test_event_data testData = this.GetComponent<test_event_data>();
        for (int index = 0; index < 28; index++)
        {
            PlanEvent(startWeek + index, testData);
        }
    }

    public void Update()
    {
        AdvanceDay();
    }
}
