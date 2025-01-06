using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;

public class Enemy : MonoBehaviour
{
    public string predmet; //naziv predmeta
    public int ECTS;

    [SerializeField] HealthBar PB_healthBar;
    [SerializeField] HealthBar RB_healthBar;
    [SerializeField] HealthBar TB_healthBar;

    public int PB;
    public int RB;
    public int TB;

    //rijecnik koji sadrzi ukupan maxhealth od enemya
    public Dictionary<string, int> health;
    public Dictionary<string, int> maxHealth;

    private Dictionary<string, HealthBar> healthBarDict = new Dictionary<string, HealthBar>();
    void Start()
    {
        HealthBar[] healthBars = GetComponentsInChildren<HealthBar>(true); // Include inactive objects
        foreach (HealthBar healthBar in healthBars)
        {
            healthBarDict[healthBar.name] = healthBar;
            healthBar.gameObject.SetActive(false); // Start with all health bars hidden
        }

    }

    public void takeDamage(string bodovi, int amount)
    {

        
        Debug.Log("Current health: " + health[bodovi].ToString());
        Debug.Log("Dmg amount: " + amount.ToString());
        health[bodovi] = health[bodovi] - amount;

        if (health[bodovi] < 0)
        {
            health[bodovi] = 0;
        }
        switch (bodovi)
        {
            case "PB":
                PB_healthBar.UpdateHealthBar(health[bodovi], PB);
                break;
            case "RB":
                RB_healthBar.UpdateHealthBar(health[bodovi], RB);
                break;
            case "TB":
                TB_healthBar.UpdateHealthBar(health[bodovi], TB);
                break;
        }
        
        if (health.Values.Sum() <= 0) {
            Die();
        }
    }

    public void spawnHealthBars()
    {
        if (PB != 0 && healthBarDict.TryGetValue("PB HealthBar", out PB_healthBar))
        {
            PB_healthBar.gameObject.SetActive(true);
            PB_healthBar.Fill();
        }
        else if (PB_healthBar != null)
        {
            PB_healthBar.gameObject.SetActive(false);
        }

        if (RB != 0 && healthBarDict.TryGetValue("RB HealthBar", out RB_healthBar))
        {
            RB_healthBar.gameObject.SetActive(true);
            RB_healthBar.Fill();
        }
        else if (RB_healthBar != null)
        {
            RB_healthBar.gameObject.SetActive(false);
        }

        if (TB != 0 && healthBarDict.TryGetValue("TB HealthBar", out TB_healthBar))
        {
            TB_healthBar.gameObject.SetActive(true);
            TB_healthBar.Fill();
        }
        else if (TB_healthBar != null)
        {
            TB_healthBar.gameObject.SetActive(false);
        }

        health = new Dictionary<string, int>
        {
        { "PB",  PB},
        { "TB", TB },
        { "RB", RB }
        };

        maxHealth = health;

    }


    public void Die()
    {
        Debug.Log("Enemy died");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
