using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DamageType
{
    Programski, Racunski, Teorijski
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
    public void DamageEnemy(DamageType type, int amount)
    {
        switch (type)
        {
            case DamageType.Programski:
                enemy.takeDamage("PB", amount);
                break;
            case DamageType.Teorijski:
                enemy.takeDamage("TB", amount);
                break;
            case DamageType.Racunski:
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
    }

    public void endGame()
    {
        overlayPanel.SetActive(true);
        endGameText.SetActive(true);
        endGameBtn.SetActive(true);
        Debug.Log("Izgubili ste!");
    }
}
