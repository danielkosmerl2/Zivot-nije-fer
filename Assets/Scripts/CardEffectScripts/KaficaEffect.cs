using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEffect/Kafica", fileName = "New Effect")]
public class KaficaEffect : CardEffect {
    public override void Effect(GameManager gameManager) {
        gameManager.deckManager.DrawCard();
        gameManager.player.UpdateEnergy(int.Parse(gameManager.player.energyValue.text) + 2);
    }
}
