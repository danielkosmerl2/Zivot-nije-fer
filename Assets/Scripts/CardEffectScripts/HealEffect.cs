using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEffect/Heal", fileName = "New Effect")]
public class HealEffect : CardEffect {
    public int amount;
    public override void Effect(GameManager gameManager) {
        gameManager.DamagePlayer(-amount);
    }
}
