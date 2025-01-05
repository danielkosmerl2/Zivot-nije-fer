using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayCard : MonoBehaviour
{

    //public GameObject playOrCancelPanel;
    public GameObject cancelPlayButton;
    public GameObject playCardButton;
    public GameObject overlayPanel;

    public void showPlayButton()
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


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
