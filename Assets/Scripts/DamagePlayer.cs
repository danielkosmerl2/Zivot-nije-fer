using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    public TextMeshProUGUI healthValue;
    public TextMeshProUGUI enemyECTS;

    public void damagePlayer()
    {
        int enemyDMG = Int32.Parse(enemyECTS.text.Substring(0,1));
        int playerHealth = Int32.Parse(healthValue.text);
        playerHealth -= enemyDMG;
        healthValue.text = playerHealth.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
