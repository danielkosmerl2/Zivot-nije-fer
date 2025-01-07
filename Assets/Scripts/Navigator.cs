using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigator : MonoBehaviour
{
    public void goToLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void goToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void goToRulesFromMenu()
    {
        SceneManager.LoadScene("Pravila_mainMenu");
    }
}
