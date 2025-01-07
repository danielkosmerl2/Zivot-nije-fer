using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEffect/Laplace", fileName = "New Effect")]
public class LaplaceEffect : CardEffect {
    public override void Effect(GameManager gameManager) {
        gameManager.statuses.Add(Statuses.Laplace);
    }
}
