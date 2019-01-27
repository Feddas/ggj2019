using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    public UnityEngine.UI.Text textCoins;

    void Start()
    {
        if (textCoins != null)
        {
            textCoins.text = HomeThings.CoinsGathered + " / " + HomeThings.CoinsNeeded;
        }
    }

    void Update() { }

    public void AddCoin()
    {
        HomeThings.CoinsGathered += 1;
    }
}
