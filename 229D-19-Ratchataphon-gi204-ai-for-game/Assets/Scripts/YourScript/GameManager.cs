using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool isGameRunning = true;
    public float survivalTime = 0f;

    void Start()
    {
        Time.timeScale = 1f;
    }

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
        Time.timeScale = 0f;
    }
}