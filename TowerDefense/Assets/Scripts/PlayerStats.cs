﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public static int money;
    public int startMoney = 100;

    public static int lives;
    public int startLives = 10;

    public static int rounds;

    private void Start()
    {
        money = startMoney;
        lives = startLives;

        rounds = 0;
    }

}
