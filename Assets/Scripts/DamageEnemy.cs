using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemy : MonoBehaviour
{
    public GameObject background;
    public Enemy enemy;
    public void Damage()
    {
        enemy.takeDamage("PB", 2);
    }
    void Start()
    {
        enemy = background.GetComponentInChildren<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
