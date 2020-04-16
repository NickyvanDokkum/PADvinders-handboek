using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KaartInfo : MonoBehaviour
{
    //kaart info
    private string[] kaarten = new string[] { "test1", "test2" };
    public int kaartID;
    [SerializeField] private Text titel;
    [SerializeField] private Text omschrijving;

    void KaartGegevens(string kaartnaam) //zorgt ervoor dat de text op kaarten wordt veranderd
    {
        if (kaartnaam == "test1")
        {
            titel.text = "111111";
            omschrijving.text = "1111111111111";
        }
        if (kaartnaam == "test2")
        {
            titel.text = "22222";
            omschrijving.text = "6969696969696969";
        }
    }

    void Update()
    {
        KaartGegevens(kaarten[kaartID]);  //kaartID zorgt ervoor dat specifieke text uit Kaartgegevens wordt aangeroepen
    }

}
