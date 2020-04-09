       using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillStatusBar: MonoBehaviour
{
    public float grades;
    public float maxStats;
    public Image fillimage;
    private Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value <= slider.minValue)
        {
            fillimage.enabled = false;
        }

        if (slider.value > slider.minValue && !fillimage.enabled)
        {
            fillimage.enabled = true;
        }

        float fillValue = grades / maxStats;
        slider.value = fillValue; 
    }
}
