using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moneyStats : MonoBehaviour
{
    // Start is called before the first frame update
    public Text moneytext;
    public int actualmoney;


    void Start()
    {
        actualmoney = 0;
    }
    void Update()
    {
        moneytext.text = "" + actualmoney;
        
    }

}
