using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Enemy : MonoBehaviour
{
    public string predmet; //naziv predmeta
    public int ECTS;

    [SerializeField] HealthBar healthBar;

    //rijecnik koji sadrzi ukupan maxhealth od enemya
    public Dictionary<string, int> health = new Dictionary<string, int>
    {
        { "PB", 3 },
        { "TB", 2 }
    }; //"PB" : 2, "TB" : 0
    public Dictionary<string, int> maxHealth = new Dictionary<string, int>
    {
        { "PB", 3 },
        { "TB", 2 }

    }; //"PB" : 2, "TB" : 0

    void Start()
    {
        healthBar = GetComponentInChildren<HealthBar>();
    }

    public void takeDamage(string bodovi, int amount)
    {
        health[bodovi] = health[bodovi] - amount;
        healthBar.UpdateHealthBar(health.Values.Sum(), maxHealth.Values.Sum());
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
