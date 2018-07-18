using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public GameObject ui;

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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void Menu()
    {

        Debug.Log("Go to Menu");

    }

}
