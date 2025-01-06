using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DamageType
{
    Programski, Racunski, Teorijski
}

public class GameManager : MonoBehaviour
{
    public GameObject background;
    private Enemy enemy;
    public void Damage(DamageType type, int amount)
    {
        switch (type)
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
}
