using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private TextMeshProUGUI textMeshPro;


    public void UpdateHealthBar(int currentVal, int maxVal)
    {
        if (maxVal > 0)
        {
            slider.value = (float)currentVal / (float)maxVal;
        }
        else
        {
            slider.value = 0f; // Default to 0 if maxVal is 0 or less
        }
        string objectName = gameObject.name;
        string firstWord = objectName.Split(' ')[0];

        textMeshPro.text = $"{currentVal} {firstWord}";
    }

    public void Fill()
    {
        slider.value = 1;
    }
    void Update()
    {

    }
    void Start()
    {
        textMeshPro = GetComponentInChildren<TextMeshProUGUI>();
    }
}
