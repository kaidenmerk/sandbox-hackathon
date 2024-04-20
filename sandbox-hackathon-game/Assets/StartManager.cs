using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StartManager : MonoBehaviour
{
    public TextMeshProUGUI countdownDisplay;
    public Button startButton;

    void Start()
    {
        startButton.onClick.AddListener(StartCountdown);
        countdownDisplay.gameObject.SetActive(false);  // Ensure the countdown is hidden initially
    }

    void StartCountdown()
    {
        startButton.gameObject.SetActive(false);  // Hide the button
        countdownDisplay.gameObject.SetActive(true);
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {

        countdownDisplay.text = "Ready?";  // Set initial text to "Ready?"
        yield return new WaitForSeconds(1f);  // Wait for a second

        int countdownTime = 3;
        while (countdownTime > 0)
        {
            countdownDisplay.text = countdownTime.ToString();
            yield return new WaitForSeconds(1f);
            countdownTime--;
        }

        countdownDisplay.text = "COUNT!";
        yield return new WaitForSeconds(1f);
        // Transition to main game logic or another scene here
        countdownDisplay.gameObject.SetActive(false);
    }
}
