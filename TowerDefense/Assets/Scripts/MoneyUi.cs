﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyUi : MonoBehaviour {

    public Text moneyText;

	// Update is called once per frame
	void Update () {

        moneyText.text = "$" + PlayerStats.money.ToString();
		
	}
}
