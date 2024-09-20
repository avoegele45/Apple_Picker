using UnityEngine;
using UnityEngine.UI;

public class StartScreenManager : MonoBehaviour
{
    public GameObject startScreen; // Reference to the start screen UI
    public Button startButton;     // Reference to the start button
    public GameObject applePicker; // Reference to the ApplePicker GameObject
    public GameObject appleTree;   // Reference to the AppleTree GameObject

    void Start()
    {
        // Initially, the ApplePicker and AppleTree are inactive
        applePicker.SetActive(false);
        appleTree.SetActive(false);
        
        // Add a listener to the button to trigger the StartGame function
        startButton.onClick.AddListener(StartGame);
    }

    void StartGame()
    {
        // Hide the start screen
        startScreen.SetActive(false);

        // Activate the ApplePicker and AppleTree scripts
        applePicker.SetActive(true);
        appleTree.SetActive(true);
    }
}
