using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public GameObject ui;
    public SceneFader sceneFader;
    public string menuSceneName = "MainMenu";

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.P))
        {

            ToggleMenu();

        }

    }

    public void ToggleMenu()
    {

        ui.SetActive(!ui.activeSelf);

        if (ui.activeSelf)
        {

            Time.timeScale = 0f;

        } else
        {

            Time.timeScale = 1f;

        }

    }

    public void Retry()
    {

        ToggleMenu();
        Time.timeScale = 1f;
        Debug.Log("Getting active scene: " + SceneManager.GetActiveScene().name);
        sceneFader.FadeTo(SceneManager.GetActiveScene().name);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void Menu()
    {

        Debug.Log("Go to Menu");
        ToggleMenu();
        Time.timeScale = 1f;
        sceneFader.FadeTo(menuSceneName);

    }

}
