using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static bool gameEnded;
    public GameObject gameOverUI;
    public SceneFader sceneFader;

    private void Start()
    {
        gameEnded = false;
    }

    // Update is called once per frame
    void Update () {

        if (gameEnded)
        {
            return;
        }

        if(Input.GetKeyDown("e"))
        {
            EndGame();
        }

        if (PlayerStats.lives <= 0)
        {
            EndGame();
        }
		
	}

    void EndGame()
    {
        gameEnded = true;

        gameOverUI.SetActive(true);

        Debug.Log("Game Over");
    }

    public void WinLevel()
    {

        Debug.Log("level won!");
        PlayerPrefs.SetInt("levelReached", PlayerPrefs.GetInt("levelReached") + 1);
        sceneFader.FadeTo("Level02");

    }
}
