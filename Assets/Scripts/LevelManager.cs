using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public Transform mainMenu, optionsMenu, creditsMenu;

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene("Play");
        Time.timeScale = 1;
    }

    public void OptionsMenu(bool clicked)
    {
        if (clicked == true)
        {
            optionsMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(false);
        }
        else
        {
            optionsMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(true);
        }

    }

    public void CreditsMenu(bool clicked)
    {
        if (clicked == true)
        {
            creditsMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(false);
        }
        else
        {
            creditsMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(true);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}﻿

