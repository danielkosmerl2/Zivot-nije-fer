using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public TextMeshProUGUI healthValue;
    public GameManager gameManager;
    
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
}
