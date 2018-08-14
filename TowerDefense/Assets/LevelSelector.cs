﻿using UnityEngine;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour {

    public SceneFader sceneFader;
    public Button[] levelButtons;

	// Use this for initialization
	void Start () {

        // persisting data
        int levelReached = PlayerPrefs.GetInt("levelReached", 1);

        for (int i = 0; i < levelButtons.Length; i++)
        {

            if (i + 1 > levelReached)
            {

                levelButtons[i].interactable = false;

            }            

        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Select (string levelName)
    {

        sceneFader.FadeTo(levelName);

    }

}
