using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class CompleteLevel : MonoBehaviour {

    public string menuSceneName = "MainMenu";
    public SceneFader sceneFader;
    private int currentLevel = 1;

    public void Continue()
    {

        if (SceneManager.GetActiveScene().buildIndex == 3)
        {

            sceneFader.FadeTo(menuSceneName);

        }

        PlayerPrefs.SetInt("levelReached", PlayerPrefs.GetInt("levelReached") + 1);
        sceneFader.FadeTo("Level" + (Int32.Parse(SceneManager.GetActiveScene().name.Substring(5)) + 1));

    }

    public void Menu()
    {
        Debug.Log("Go to menu!");
        sceneFader.FadeTo(menuSceneName);
    }

}
