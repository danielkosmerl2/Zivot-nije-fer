using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEffect/Rekurzija", fileName = "New Effect")]
public class RekurzijaEffect : CardEffect {
    public int amount = 2;
    public DamageType type = DamageType.Programski;
    public Card rekurzija;
    public override void Effect(GameManager gameManager) {
        gameManager.DamageEnemy(type, amount);
        gameManager.deckManager.cards.Add(rekurzija);
    }
}
