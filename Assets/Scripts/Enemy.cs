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
    void Start()
    {
        health = new Dictionary<string, int>
        {
        { "PB",  PB},
        { "TB", TB },
        { "RB", RB }
        };

        maxHealth = health;


        HealthBar[] healthBars = GetComponentsInChildren<HealthBar>();

        foreach (HealthBar healthBar in healthBars)
        {
            if (healthBar.name == "RB HealthBar")
            {
                RB_healthBar = healthBar;
                RB_healthBar.UpdateHealthBar(maxHealth["RB"], maxHealth["RB"]);
            }
            if (healthBar.name == "PB HealthBar")
            {
                PB_healthBar = healthBar;
                PB_healthBar.UpdateHealthBar(maxHealth["PB"], maxHealth["PB"]);
            }
            if (healthBar.name == "TB HealthBar")
            {
                TB_healthBar = healthBar;
                TB_healthBar.UpdateHealthBar(maxHealth["TB"], maxHealth["TB"]);
            }
        }


    }

    public void takeDamage(string bodovi, int amount)
    {
        health[bodovi] = health[bodovi] - amount;
        if (health[bodovi] < 0)
        {
            health[bodovi] = 0;
        }
        switch (bodovi)
        {
            case "PB":
                PB_healthBar.UpdateHealthBar(health[bodovi], maxHealth[bodovi]);
                break;
            case "RB":
                RB_healthBar.UpdateHealthBar(health[bodovi], maxHealth[bodovi]);
                break;
            case "TB":
                TB_healthBar.UpdateHealthBar(health[bodovi], maxHealth[bodovi]);
                break;
        }
        
        if (health.Values.Sum() < 0) {
            Die();
        }
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
