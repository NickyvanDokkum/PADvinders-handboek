using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calendar : MonoBehaviour
{
    List<DayInformation> plannedDays;
    int currentDay;

    // Start is called before the first frame update
    void Start()
    {
        currentDay = 1;
        plannedDays = new List<DayInformation>();
    }

    public void AdvanceDay()
    //elke dag is er ook nog een structured event maar daar hoef ik niks mee te doen
    {

        currentDay++;

        //check of de week is afgelopen om vervolgens de huur te betalen
        if (currentDay / 8 == currentDay % 8)
        {
            //betaal de huur

            //verwijder de dingen uit de list van de vorige week
            for (int index = plannedDays.Count - 1; index >= 0; index--)
            {
                DayInformation plannedDay = plannedDays[index];

                if (plannedDay.day < currentDay)
                {
                    plannedDays.Remove(plannedDay);

                }
            }

        }

        //check of er event zijn ingepland voor de volgende dag
        foreach (DayInformation plannedDay in plannedDays)
        {
            if (plannedDay.day == currentDay)
            {
                //begin het event
                break;
            }
            else
            {
                // er is geen event geplanned voor vandaag
            }
        }
    }

    //nog niet getest
    public List<DayInformation> GetEventsForFourWeeks()
    {
        List<DayInformation> events = new List<DayInformation>();

        //hoeveel dagen er in 4 weken zitten plus 1
        int days = 29;

        if(days > plannedDays.Count)
        {
            days = plannedDays.Count;
        }

        for (int index = 0; index < days; index++)
        {
            events.Add(plannedDays[index]);
        }

        return events;
    }

    public void PlanEvent(int day, test_event_data cardEvent)
    {
        plannedDays.Add(new DayInformation(day, cardEvent));
    }

    public class DayInformation
    {
        public int day;
        test_event_data cardEvent;

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
        test_event_data cardEvent = new test_event_data();

        for (int index = 0; index < 28; index++)
        {
            PlanEvent(startWeek + index, cardEvent);
        }
    }
}
