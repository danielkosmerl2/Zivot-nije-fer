using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider slider;

    public void UpdateHealthBar(int currentVal, int maxVal)
    {
        slider.value = (float)currentVal/(float)maxVal;
    }
    void Update()
    {
        
    }
}
