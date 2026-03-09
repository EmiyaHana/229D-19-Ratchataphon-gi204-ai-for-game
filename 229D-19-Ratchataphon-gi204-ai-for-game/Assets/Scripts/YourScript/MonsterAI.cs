using UnityEngine;

public class MonsterAI : MonoBehaviour
{
    public float speed = 3f;
    Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (!GameManager.instance.isGameRunning) return;

        Vector3 dir = (player.position - transform.position).normalized;

        transform.position += dir * speed * Time.deltaTime;
    }
}