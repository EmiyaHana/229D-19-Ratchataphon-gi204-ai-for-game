using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool isGameRunning = true;
    public float survivalTime = 0f;

    void Awake()
    {
        instance = this;
        isGameRunning = true;
    }

    void Update()
    {
        if (!isGameRunning) return;

        survivalTime += Time.deltaTime;
    }

    public void GameOver()
    {
        isGameRunning = false;
        Time.timeScale = 0f;
    }
}