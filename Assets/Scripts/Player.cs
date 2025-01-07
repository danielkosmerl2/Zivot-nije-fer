using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public TextMeshProUGUI healthValue;
    public TextMeshProUGUI energyValue;
    public GameManager gameManager;
    public int maxEnergy = 3;
    
    public void UpdateHealth(int amount)
    {
        int playerHealth = int.Parse(healthValue.text);
        playerHealth += amount;
        if (playerHealth <= 0)
        {
            gameManager.endGame();
        }
        healthValue.text = playerHealth.ToString();
    }

    public void UpdateEnergy(int amount)
    {
        energyValue.text = amount.ToString();
    }
}
