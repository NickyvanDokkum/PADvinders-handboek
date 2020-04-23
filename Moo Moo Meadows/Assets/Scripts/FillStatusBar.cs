       using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillStatusBar: MonoBehaviour
{
    public float currentStats;
    public float maxStats;
    public Image fillimage;
    private Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }


    void Update()
    {
        float fillValue = currentStats / maxStats;
        slider.value = fillValue; 
    }

    
    public void SetStat(int stat)
    {
        currentStats = stat;
        Update();
    }

    public void AddValue(int stat)
    {
        currentStats += stat;
        Update();
    }
    
}
