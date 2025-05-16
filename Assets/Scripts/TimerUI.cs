using TMPro;
using UnityEngine;

public class TimerUI : MonoBehaviour
{
    private TextMeshProUGUI timerText;

    private void Awake()
    {
        timerText=GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.OnTimerUpdate += OnTimerUpdate;
        }
    }

    private void OnTimerUpdate(float timer) 
    {
        timerText.text = $"Timer: {timer}";
    }

    private void OnDestroy()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.OnTimerUpdate -= OnTimerUpdate;
        }
    }
}
