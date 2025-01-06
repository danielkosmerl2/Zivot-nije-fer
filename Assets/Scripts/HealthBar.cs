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
        slider.value = (float)currentVal / (float)maxVal;
        string objectName = gameObject.name;
        string firstWord = objectName.Split(' ')[0];

        textMeshPro.text = $"{currentVal} {firstWord}";
    }
    void Update()
    {

    }
    void Start()
    {
        textMeshPro = GetComponentInChildren<TextMeshProUGUI>();
    }
}
