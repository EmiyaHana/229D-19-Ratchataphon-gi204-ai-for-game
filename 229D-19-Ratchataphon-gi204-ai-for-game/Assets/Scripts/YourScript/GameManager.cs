using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool isGameRunning = true;

    public float survivalTime = 0f;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        if (!isGameRunning) return;

        survivalTime += Time.deltaTime;
    }

    public void GameOver()
    {
        isGameRunning = false;

        PlayerPrefs.SetFloat("LastTime", survivalTime);

        SceneManager.LoadScene("Result");
    }
}