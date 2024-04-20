using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoreScript : MonoBehaviour
{
    public int playerScore;
    public TextMeshProUGUI scoreText;

    [ContextMenu("addToScore")]
    public void addScore()
    {
        playerScore++;
        scoreText.text = playerScore.ToString();
    }

}
