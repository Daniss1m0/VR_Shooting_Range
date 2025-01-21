using UnityEngine;
using TMPro;

public class TimerManager : MonoBehaviour
{
    public TMP_Text timerText; // Текстовое поле для отображения времени
    public TMP_Text messageText; // Текстовое поле для вывода сообщения (например, "Time's up!")
    private float timer = 0f; // Значение таймера
    private bool isRunning = false; // Флаг, указывает, работает ли таймер
    private const float timeLimit = 30f; // Лимит времени в секундах

    public void StartTimer()
    {
        isRunning = true;
        messageText.text = ""; // Очищаем текст сообщения при старте таймера
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

            // Проверяем, достиг ли таймер лимита
            if (timer >= timeLimit)
            {
                TimerEnded();
            }

            UpdateTimerText();
        }
    }

    private void UpdateTimerText()
    {
        // Форматируем время в виде "минуты:секунды.миллисекунды"
        int minutes = Mathf.FloorToInt(timer / 60f);
        int seconds = Mathf.FloorToInt(timer % 60f);
        int milliseconds = Mathf.FloorToInt((timer * 1000) % 1000);

        timerText.text = $"Time: {minutes:00}:{seconds:00}:{milliseconds:00}";
    }

    private void TimerEnded()
    {
        isRunning = false; // Останавливаем таймер
        messageText.text = "Time's up!"; // Выводим сообщение
        messageText.color = Color.red; // Делаем текст красным
    }
}
