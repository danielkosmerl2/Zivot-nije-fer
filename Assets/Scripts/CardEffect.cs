using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CardEffect : ScriptableObject {
    public abstract void Effect(GameManager gameManager);
}

[CreateAssetMenu(menuName = "CardEffect/Damage", fileName = "New Effect")]
public class DamageEffect : CardEffect {
    public int amount;
    public DamageType type;
    public override void Effect(GameManager gameManager) {
        gameManager.Damage(type, amount);
    }
}
