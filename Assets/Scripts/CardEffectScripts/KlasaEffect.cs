using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEffect/Klasa", fileName = "New Effect")]
public class KlasaEffect : CardEffect {
    public override void Effect(GameManager gameManager) {
        gameManager.statuses.Add(Statuses.Klasa);
    }
}
