using UnityEngine;
using TMPro; // Use UnityEngine.UI if you're not using TextMeshPro

public class TimerScript : MonoBehaviour
{
    public TextMeshProUGUI timerText; // Drag and drop the TimerText object here
    public float timeRemaining = 60f; // Starting time in seconds
    private bool timerIsRunning = true;

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime; // Reduce time
                UpdateTimerDisplay(timeRemaining);
            }
            else
            {
                Debug.Log("Time's Up!");
                timeRemaining = 0;
                timerIsRunning = false;
                // Add logic to handle end-of-timer events (e.g., restart level, game over)
            }
        }
    }

    void UpdateTimerDisplay(float timeToDisplay)
    {
        timeToDisplay = Mathf.Max(timeToDisplay, 0); // Ensure no negative values
        float minutes = Mathf.FloorToInt(timeToDisplay / 60); // Calculate minutes
        float seconds = Mathf.FloorToInt(timeToDisplay % 60); // Calculate seconds
        timerText.text = $"Time: {minutes:00}:{seconds:00}"; // Format and display
    }
}
