using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteLevel : MonoBehaviour {

    public string menuSceneName = "MainMenu";
    public SceneFader sceneFader;

    public void Continue()
    {

        PlayerPrefs.SetInt("levelReached", PlayerPrefs.GetInt("levelReached") + 1);
        sceneFader.FadeTo("Level02");

    }

    public void Menu()
    {
        Debug.Log("Go to menu!");
        sceneFader.FadeTo(menuSceneName);
    }

}
