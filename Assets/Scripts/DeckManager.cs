using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckManager : MonoBehaviour
{
    public List<Card> cards = new List<Card>();
    public HandManager handManager;

    public void DrawCard()
    {
        if(cards.Count == 0) return;
        Card nextCard = cards[0];
        cards.RemoveAt(0);
        handManager.AddCard(nextCard);
    }
}
