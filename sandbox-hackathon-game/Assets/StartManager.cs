using UnityEngine;
using TMPro;
using System.Collections;

public class StartManager : MonoBehaviour
{
    public TextMeshProUGUI countdownDisplay;
    public TextMeshProUGUI roomCodeDisplay; // This UI element displays the room code
    public TextMeshProUGUI waitingForHostText; // Text to display while waiting for the host

    void Start()
    {
 
        waitingForHostText.gameObject.SetActive(true);
        waitingForHostText.text = "Waiting for host to start the game...";
        countdownDisplay.gameObject.SetActive(false);
        roomCodeDisplay.gameObject.SetActive(true);
    }

    public void UpdateRoomCode(string roomCode)
    {
        roomCodeDisplay.text = "Room Code: " + roomCode;
    }

    public void StartGameCountdown()
    {
        waitingForHostText.gameObject.SetActive(false);
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
