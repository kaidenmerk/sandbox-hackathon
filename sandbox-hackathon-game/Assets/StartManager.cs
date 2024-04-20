using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;

public class StartManager : MonoBehaviour
{
    public TextMeshProUGUI countdownDisplay;
    public Button startButton;
    public TextMeshProUGUI roomCodeDisplay; // This UI element displays the room code

    void Awake()
    {
        startButton.onClick.AddListener(HandleStartButtonClick);
        startButton.gameObject.SetActive(false);  // Start with the button hidden
        countdownDisplay.gameObject.SetActive(false);  // Ensure the countdown is hidden initially
        roomCodeDisplay.text = "Room Code: "; // Initial text setting
    }

    public void UpdateRoomCode(string roomCode)
    {
        roomCodeDisplay.text = "Room Code: " + roomCode;  // Update display when called
        startButton.gameObject.SetActive(true);  // Show the button once room code is set
    }

    private void HandleStartButtonClick()
    {
        startButton.gameObject.SetActive(false); // Hide the button
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {
        countdownDisplay.gameObject.SetActive(true);
        countdownDisplay.text = "Ready?";
        yield return new WaitForSeconds(1);

        for (int countdownTime = 3; countdownTime > 0; countdownTime--)
        {
            countdownDisplay.text = countdownTime.ToString();
            yield return new WaitForSeconds(1);
        }

        countdownDisplay.text = "GO!";
        yield return new WaitForSeconds(1);

        countdownDisplay.gameObject.SetActive(false);
        GameManager.Instance.StartGame();  // Delegate to GameManager to start the game
    }
}
