using UnityEngine;
using TMPro;

public class TimerManager : MonoBehaviour
{
    public TMP_Text timerText;
    public TMP_Text messageText;
    private float timer = 0f;
    private bool isRunning = false;
    private const float timeLimit = 30f;

    public void StartTimer()
    {
        isRunning = true;
        messageText.text = "";
    }

    public void StopTimer()
    {
        isRunning = false;
    }

    private void Update()
    {
        if (isRunning)
        {
            timer += Time.deltaTime;

            if (timer >= timeLimit)
            {
                TimerEnded();
            }

            UpdateTimerText();
        }
    }

    private void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(timer / 60f);
        int seconds = Mathf.FloorToInt(timer % 60f);
        int milliseconds = Mathf.FloorToInt((timer * 1000) % 1000);

        timerText.text = $"Time: {minutes:00}:{seconds:00}:{milliseconds:00}";
    }

    private void TimerEnded()
    {
        isRunning = false;
        messageText.text = "Time's up!";
        messageText.color = Color.red;
    }
}
