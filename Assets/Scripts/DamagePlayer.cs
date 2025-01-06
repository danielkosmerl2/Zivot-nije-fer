using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DamagePlayer : MonoBehaviour
{
    public TextMeshProUGUI healthValue;
    public TextMeshProUGUI enemyECTS;
    public GameObject overlayPanel;
    public GameObject endGameText;
    public GameObject endGameBtn;

    public void damagePlayer()
    {
        int enemyDMG = Int32.Parse(enemyECTS.text.Substring(0,1));
        int playerHealth = Int32.Parse(healthValue.text);
        playerHealth -= enemyDMG;
        if (playerHealth <= 0)
        {
            endGame();
        }
        healthValue.text = playerHealth.ToString();
    }

    public void endGame()
    {
        overlayPanel.SetActive(true);
        endGameText.SetActive(true);
        endGameBtn.SetActive(true);
        Debug.Log("Izgubili ste!");
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
