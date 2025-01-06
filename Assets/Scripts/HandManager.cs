using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandManager : MonoBehaviour
{
    public List<GameObject> cards = new List<GameObject>();
    public GameObject cardPrefab;
    public float cardSpacing = 100f;
    public Transform handTransform;
    public GameObject cancelPlayButton;
    public GameObject playCardButton;
    public GameObject overlayPanel;
    public int handSize = 5;
    private GameObject selected;
    public GameManager gameManager;
    void Start()
    {

    }

    public void AddCard(Card card)
    {
        GameObject newCard = Instantiate(cardPrefab, handTransform.position, Quaternion.identity, handTransform);
        newCard.GetComponent<Button>().onClick.AddListener(() => SelectCard(newCard));
        cards.Add(newCard);

        newCard.GetComponent<CardDisplay>().card = card;
    }

    public void RemoveCard(int index)
    {
        GameObject card = cards[index];
        RemoveCard(card);
    }

    public void RemoveCard(GameObject card)
    {
        cards.Remove(card);
        Destroy(card);
    }

    public void UpdateVisuals()
    {
        for(int i = 0; i < cards.Count; i++){
            cards[i].transform.localPosition = new Vector3(cardSpacing * (i - (cards.Count - 1) / 2f), 0f, 0f);
        }
    }

    private void SelectCard(GameObject card)
    {
        selected = card;
        overlayPanel.SetActive(true);
        cancelPlayButton.SetActive(true);
        playCardButton.SetActive(true);
        playCardButton.GetComponent<Button>().onClick.AddListener(PlayCard);
    }

    private void PlayCard()
    {
        if(!selected) return;
        selected.GetComponent<CardDisplay>().card.effect.Effect(gameManager);
        RemoveCard(selected);
        cancelPlayCard();
        UpdateVisuals();
    }

    public void cancelPlayCard()
    {
        overlayPanel.SetActive(false);
        cancelPlayButton.SetActive(false);
        playCardButton.SetActive(false);
        selected = null;
    }
}
