using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemy : MonoBehaviour
{
    public GameObject background;
    public DamageType damageType;
    public int amount = 2;
    private Enemy enemy;
    public void Damage()
    {
        switch (damageType)
        {
            case DamageType.Programski:
                enemy.takeDamage("PB", amount);
                break;
            case DamageType.Teorijski:
                enemy.takeDamage("TB", amount);
                break;
            case DamageType.Racunski:
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
