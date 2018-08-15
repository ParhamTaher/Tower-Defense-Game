using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    public string menuSceneName = "MainMenu";
    public SceneFader sceneFader;

    public void Retry()
    {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        sceneFader.FadeTo(SceneManager.GetActiveScene().name);
    }

    public void Menu()
    {
        Debug.Log("Go to menu!");
        sceneFader.FadeTo(menuSceneName);
    }
}
