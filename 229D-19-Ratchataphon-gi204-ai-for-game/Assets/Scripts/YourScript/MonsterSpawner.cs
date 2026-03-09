using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    public GameObject monsterPrefab;
    public float spawnInterval = 20f;
    public float arenaSize = 20f;

    float timer = 0;

    void Update()
    {
        if (!GameManager.instance.isGameRunning) return;

        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnMonster();
            timer = 0;
        }
    }

    void SpawnMonster()
    {
        Vector3 pos = new Vector3(
            Random.Range(-arenaSize, arenaSize),
            0,
            Random.Range(-arenaSize, arenaSize)
        );

        Instantiate(monsterPrefab, pos, Quaternion.identity);
    }
}