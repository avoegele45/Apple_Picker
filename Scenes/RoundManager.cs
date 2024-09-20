using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RoundManager : MonoBehaviour
{
    public ApplePicker applePicker; // Reference to ApplePicker script
    public Text roundText; // UI Text for showing the round
    public Button restartButton; // UI Button for restarting
    private int currentRound = 1;
    private int totalRounds = 4;
    private bool isGameOver = false;

    void Start()
    {
        UpdateRoundText();
        restartButton.onClick.AddListener(RestartGame);
        restartButton.gameObject.SetActive(false); // Hide the restart button initially
    }

    public void NextRound()
    {
        if (currentRound < totalRounds)
        {
            currentRound++;
            UpdateRoundText();
        }
        else
        {
            GameOver();
        }
    }

    void UpdateRoundText()
    {
        if (!isGameOver)
        {
            roundText.text = "Round " + currentRound;
        }
    }

    void GameOver()
    {
        isGameOver = true;
        roundText.text = "Game Over";
        restartButton.gameObject.SetActive(true); // Show the restart button
    }

    public void RestartGame()
    {
        isGameOver = false;
        currentRound = 1; // Reset to Round 1
        UpdateRoundText();
        restartButton.gameObject.SetActive(false); // Hide the restart button again

        // Call the RestartRound method from ApplePicker to reset baskets
        if (applePicker != null)
        {
            applePicker.RestartRound();
        }
        else
        {
            Debug.LogError("ApplePicker reference not set.");
        }
    }
}
