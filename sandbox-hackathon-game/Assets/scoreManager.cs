using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;

    void Start()
    {
        UpdateScoreText();
    }

    // This method will be called whenever you want to update the score
    public void AddToScore()
    {
        score++;
        UpdateScoreText();
    }

    public void SubtractToScore()
    {
        score--;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
