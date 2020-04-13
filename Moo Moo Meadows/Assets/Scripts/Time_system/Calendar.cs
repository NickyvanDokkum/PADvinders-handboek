using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.UI;

public class Calendar : MonoBehaviour
{
    List<dayInformation> plannedDays;
    int currentDay;


    Text txt;


    // Start is called before the first frame update
    void Start()
    {
        currentDay = 1;
        plannedDays = new List<dayInformation>();


        txt = transform.Find("Text").GetComponent<Text>();

        txt.text = "hij is gestart";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void advanceDay()
    //elke dag is er ook nog een structured event maar daar hoef ik niks mee te doen
    {
        txt.text = "hij gaat nu over naar de volgende dag";

        currentDay++;

        txt.text = "de dag is nu" + currentDay;

        //check of de week is afgelopen om vervolgens de huur te betalen
        if (currentDay / 8 == currentDay % 8)
        {
            txt.text = "er is een week voorbij";
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
                txt.text = "er is een event";

                break;
            }
        }
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
