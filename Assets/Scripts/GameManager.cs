using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DamageType
{
    Programski, Racunski, Teorijski
}

public enum Statuses
{
    Klasa, Laplace, Razumijevanje
}

public class GameManager : MonoBehaviour
{
    public GameObject background;
    public Enemy enemy;
    public Player player;
    public GameObject overlayPanel;
    public GameObject endGameText;
    public GameObject endGameBtn;
    public DeckManager deckManager;
    public List<Statuses> statuses;
    public void DamageEnemy(DamageType type, int amount)
    {
        if (statuses.Contains(Statuses.Razumijevanje)) {
            type = DamageType.Teorijski;
            statuses.Remove(Statuses.Razumijevanje);
        }
        switch (type)
        {
            case DamageType.Programski:
                if (statuses.Contains(Statuses.Klasa)) {
                    amount += 1;
                }
                enemy.takeDamage("PB", amount);
                break;
            case DamageType.Teorijski:
                enemy.takeDamage("TB", amount);
                break;
            case DamageType.Racunski:
                if (statuses.Contains(Statuses.Laplace)) {
                    amount *= 2;
                    statuses.Remove(Statuses.Laplace);
                }
                enemy.takeDamage("RB", amount);
                break;
            default:
                Debug.Log("No action defined for this button");
                break;
        }
    }

    public void DamagePlayer(int amount)
    {
        player.UpdateHealth(-amount);
    }

    public void EndTurn()
    {
        player.UpdateHealth(-enemy.ECTS);
        player.UpdateEnergy(player.maxEnergy);
        statuses.Remove(Statuses.Klasa);
    }

    public void endGame()
    {
        overlayPanel.SetActive(true);
        endGameText.SetActive(true);
        endGameBtn.SetActive(true);
    }
}
