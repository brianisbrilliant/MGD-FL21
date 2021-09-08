using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private int totalCoins = 0;

    public void UpdateScore(int givenChange = 1) {
        totalCoins += givenChange;
        scoreText.text = "Coins: " + totalCoins;
    }


}
