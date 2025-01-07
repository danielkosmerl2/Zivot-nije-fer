using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEffect/Draw", fileName = "New Effect")]
public class DrawEffect : CardEffect {
    public int amount;
    public override void Effect(GameManager gameManager) {
        for(int i=0; i<amount; i++) {
            gameManager.deckManager.DrawCard();
        }
    }
}
