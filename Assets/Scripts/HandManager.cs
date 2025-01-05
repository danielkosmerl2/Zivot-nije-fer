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
    void Start()
    {

    }

    public void AddCard(Card card)
    {
        GameObject newCard = Instantiate(cardPrefab, handTransform.position, Quaternion.identity, handTransform);
        newCard.GetComponent<Button>().onClick.AddListener(showPlayButton);
        cards.Add(newCard);

        newCard.GetComponent<CardDisplay>().card = card;

        UpdateVisuals();
    }

    private void UpdateVisuals()
    {
        for(int i = 0; i < cards.Count; i++){
            cards[i].transform.localPosition = new Vector3(cardSpacing * (i - (cards.Count - 1) / 2f), 0f, 0f);
        }
    }

    private void showPlayButton()
    {
        overlayPanel.SetActive(true);
        cancelPlayButton.SetActive(true);
        playCardButton.SetActive(true);
    }

    public void cancelPlayCard()
    {
        overlayPanel.SetActive(false);
        cancelPlayButton.SetActive(false);
        playCardButton.SetActive(false);
    }
}
