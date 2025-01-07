using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardEffect/Party", fileName = "New Effect")]
public class PartyEffect : CardEffect {
    public int health = 10;
    public override void Effect(GameManager gameManager) {
        gameManager.player.SetHealth(health);
    }
}
