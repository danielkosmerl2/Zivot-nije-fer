using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemy : MonoBehaviour
{
    public GameObject background;
    public string bod_type;
    private int amount = 2;
    public Enemy enemy;
    public void Damage()
    {
        switch (bod_type)
        {
            case "PB DMG":
                enemy.takeDamage("PB", amount);
                break;
            case "TB DMG":
                enemy.takeDamage("TB", amount);
                break;
            case "RB DMG":
                enemy.takeDamage("RB", amount);
                break;
            default:
                Debug.Log("No action defined for this button");
                break;
        }
    }
    void Start()
    {
        enemy = background.GetComponentInChildren<Enemy>();
        bod_type = gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
