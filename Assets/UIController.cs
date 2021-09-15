using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public string scoreName = "Coins";

    private int totalCoins = 0;

    public void UpdateScore(int givenChange = 1) {
        totalCoins += givenChange;
        scoreText.text = scoreName + ": " + totalCoins;
    }


}
