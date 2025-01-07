using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DeckManager : MonoBehaviour
{
    public List<Card> cards = new List<Card>();
    public List<Card> discard = new List<Card>();
    public HandManager handManager;
    public TextMeshProUGUI deckCounter;
    public TextMeshProUGUI discardCounter;

    void Start()
    {
        List<Card> shuffled = new List<Card>();
        int count = cards.Count;
        for(int i = 0; i < count; i++){
            int index = Random.Range(0, cards.Count);
            shuffled.Add(cards[index]);
            cards.RemoveAt(index);
        }
        cards = shuffled;

        DrawHand();
    }

    public void DrawHand()
    {
        while(handManager.cards.Count < handManager.handSize){
            DrawCard();
        }
        handManager.UpdateVisuals();
    }

    public void DrawCard()
    {
        if(cards.Count == 0){
            if(discard.Count == 0) return;
            int count = discard.Count;
            for(int i = 0; i < count; i++){
                int index = Random.Range(0, discard.Count);
                cards.Add(discard[index]);
                discard.RemoveAt(index);
            }
        }
        Card nextCard = cards[0];
        cards.RemoveAt(0);
        handManager.AddCard(nextCard);
        deckCounter.text = cards.Count.ToString();
        discardCounter.text = discard.Count.ToString();
    }

    public void DiscardHand()
    {
        while(handManager.cards.Count > 0){
            handManager.RemoveCard(0);
        }
    }

    public void Discard(Card card)
    {
        discard.Add(card);
        discardCounter.text = discard.Count.ToString();
    }

    public void DiscardAndDraw()
    {
        DiscardHand();
        DrawHand();
    }
}
