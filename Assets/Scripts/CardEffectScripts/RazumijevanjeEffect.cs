using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEffect/Razumijevanje", fileName = "New Effect")]
public class RazumijevanjeEffect : CardEffect {
    public override void Effect(GameManager gameManager) {
        gameManager.statuses.Add(Statuses.Razumijevanje);
    }
}
