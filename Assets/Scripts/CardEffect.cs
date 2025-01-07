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
        gameManager.DamageEnemy(type, amount);
    }
}

[CreateAssetMenu(menuName = "CardEffect/Heal", fileName = "New Effect")]
public class HealEffect : CardEffect {
    public int amount;
    public override void Effect(GameManager gameManager) {
        gameManager.DamagePlayer(-amount);
    }
}

[CreateAssetMenu(menuName = "CardEffect/Draw", fileName = "New Effect")]
public class DrawEffect : CardEffect {
    public int amount;
    public override void Effect(GameManager gameManager) {
        for(int i=0; i<amount; i++) {
            gameManager.deckManager.DrawCard();
        }
    }
}
