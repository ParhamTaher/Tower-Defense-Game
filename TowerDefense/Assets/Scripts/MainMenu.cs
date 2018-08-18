using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public string levelToLoad = "LevelSelector";
    public SceneFader sceneFader;

    public void Play()
    {
        // Temp Fix
        // PlayerPrefs.DeleteAll();
        sceneFader.FadeTo(levelToLoad);

    }

    public void Quit()
    {

        Debug.Log("Exiting...");
        Application.Quit();

    }

}
