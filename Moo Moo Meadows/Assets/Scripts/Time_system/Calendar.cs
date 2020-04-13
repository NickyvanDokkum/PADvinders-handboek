using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calendar : MonoBehaviour
{
    List<dayInformation> plannedDays;
    int currentDay;

    // Start is called before the first frame update
    void Start()
    {
        currentDay = 1;
        plannedDays = new List<dayInformation>();
    }

    public void advanceDay()
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
                dayInformation plannedDay = plannedDays[index];

                if (plannedDay.day < currentDay)
                {
                    plannedDays.Remove(plannedDay);

                }
            }

        }

        //check of er event zijn ingepland voor de volgende dag
        foreach (dayInformation plannedDay in plannedDays)
        {
            if (plannedDay.day == currentDay)
            {
                //begin het event

                break;
            }
        }
    }

    public void planEvent(int day)
    {
        plannedDays.Add(new dayInformation(day));
    }

    class dayInformation
    {
        public int day;

        public dayInformation(int day)
        {
            this.day = day;
        }
    }
}
