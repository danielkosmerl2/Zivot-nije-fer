using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEffect/Damage", fileName = "New Effect")]
public class DamageEffect : CardEffect {
    public int amount;
    public DamageType type;
    public override void Effect(GameManager gameManager) {
        gameManager.DamageEnemy(type, amount);
    }
}
