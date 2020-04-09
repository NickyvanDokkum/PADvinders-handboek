using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kalendar : MonoBehaviour
{
    List<dayInformation> days;
    int currentDay;
    const int planLimit = 30;

    // Start is called before the first frame update
    void Start()
    {
        currentDay = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void advanceDay(string activity)
        //elke dag is er ook nog een structured event maar daar hoef ik niks mee te doen
    {
        // de dag begint niet op 0 maar de array wel dus eerst de loop en dan de dag++
        for (int index = currentDay; index < days.length && index < currentDay+planLimit; index++)
        {
            // check of er een challenge is
            dayInformation day = days[index];
            if (day.activity)
            {
                //check of je hem al kan halen
                if(currentDay >= day.day - day.time)
                {
                    day.repeadChallenge--;
                    if (day.repeadChallenge == 0)
                    {
                        // je hebt het event gehaald maar nu zijn er nog geen beloningen
                        day.challengeCompleted();
                    }
                }
            }

            // check of er een lopend event is en of die is gehaald
            //als het event is voorlopen zonder het te halen dan komt er een straf
        }

        currentDay++;

        // checked of er een event is voorlopen en of dat is vooltooid?
    }

    class dayInformation
    {
        public int day;

        // hoeveel dagen je hebt voordat je kan beginnen aan het event
        public int time;
        // hoe je het event haalt
        public string activity;
        // hoevaak je het event nog moet halen
        public int repeadChallenge;
        
        // ik moet nog iets bedenken voor de beloningen

        public dayInformation(int day)
        {
            this.day = day;
        }

        public void challengeCompleted()
        {
            day.activity = null;
            day.time = null;
            day.repeadChallenge = null;
        }
    }
}
