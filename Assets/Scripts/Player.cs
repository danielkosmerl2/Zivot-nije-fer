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
    public int energy;

    public ShowEnergy showEnergy;

    public void Start()
    {
        energy = maxEnergy;
    }

    public void SetHealth(int amount)
    {
        healthValue.text = amount.ToString();
    }
    
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
        showEnergy.UpdateElements(amount);
    }
}
