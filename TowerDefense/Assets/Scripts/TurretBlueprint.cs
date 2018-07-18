using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Does not attach to a game object ( no Monobheaviour )

[System.Serializable]
public class TurretBlueprint {

    public GameObject prefab;
    public int cost;

    public GameObject upgradedPrefab;
    public int upgradeCost;

    public int GetSellAmount()
    {
        return cost / 2;
    }
    
}
