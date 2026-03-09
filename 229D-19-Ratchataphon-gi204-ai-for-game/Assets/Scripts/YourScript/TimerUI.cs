using UnityEngine;
using UnityEngine.UI;

public class TimerUI : MonoBehaviour
{
    public Text timerText;

    void Update()
    {
        float t = GameManager.instance.survivalTime;

        int minutes = Mathf.FloorToInt(t / 60);
        int seconds = Mathf.FloorToInt(t % 60);

        timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }
}