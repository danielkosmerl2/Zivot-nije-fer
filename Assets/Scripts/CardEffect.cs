using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CardEffect : ScriptableObject {
    public abstract void Effect(GameManager gameManager);
}

[CreateAssetMenu(menuName = "CardEffect/Damage", fileName = "New Effect")]
public class DamageEffect : CardEffect {
    public override void Effect(GameManager gameManager) {
        gameManager.Damage(DamageType.Programski, 2);
    }
}
