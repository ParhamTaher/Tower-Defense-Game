﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RoundsSurvived : MonoBehaviour
{

    public Text roundsText;

    private void OnEnable()
    {
        StartCoroutine(AnimateText());
    }

    IEnumerator AnimateText()
    {

        roundsText.text = "0";
        int round = 0;

        yield return new WaitForSeconds(0.7f);

        while( round < PlayerStats.rounds)
        {

            round += 1;
            roundsText.text = round.ToString();

            yield return new WaitForSeconds(0.05f);

        }


    }

}
