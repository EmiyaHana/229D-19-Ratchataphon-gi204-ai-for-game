using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultScreen : MonoBehaviour
{
    public Text resultText;

    void Start()
    {
        float time = PlayerPrefs.GetFloat("LastTime", 0);

        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);

        resultText.text = "Time Survived\n" +
            minutes.ToString("00") + ":" + seconds.ToString("00");
    }

    public void Retry()
    {
        SceneManager.LoadScene("Game");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}