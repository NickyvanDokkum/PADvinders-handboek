using UnityEngine;
using UnityEngine.UI;

public class KaartInfo : MonoBehaviour
{
    //kaart info
    private string[] kaarten = new string[] { "test1", "test2" };
    public int kaartID;
    [SerializeField] private Text titel;
    [SerializeField] private Text omschrijving;
    public static string eventnaam;
    string eventdinges;

    public void KaartGegevens(string kaartnaam) //zorgt ervoor dat de text op kaarten wordt veranderd
    {
        switch (eventnaam)
        {
            case "aaa":
                switch (kaartnaam)
                {
                    case "test1":
                        titel.text = "111111111";
                        omschrijving.text = "1111111111111";
                        break;
                    case "test2":
                        titel.text = "22222";
                        omschrijving.text = "6969696969696969";
                        break;
                }
                break;
        }
        switch (eventnaam)
        {
            case "bbb":
                switch (kaartnaam)
                {
                    case "test1":
                        titel.text = "123123";
                        omschrijving.text = "11111111231232111111";
                        break;
                    case "test2":
                        titel.text = "1231223";
                        omschrijving.text = "12312";
                        break;
                }
                break;
        }
    }

    void Update()
    {
        KaartGegevens(kaarten[kaartID]);  //kaartID zorgt ervoor dat specifieke text uit Kaartgegevens wordt aangeroepen
    }

}
