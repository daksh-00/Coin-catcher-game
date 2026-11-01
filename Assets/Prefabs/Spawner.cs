
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public GameObject bombPrefab;

    public float spawnInterval = 1.5f;
    public float spawnXRange = 8f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnObject), 1f, spawnInterval);
    }

    void SpawnObject()
    {
        float randomX = Random.Range(-spawnXRange, spawnXRange);
        Vector3 spawnPosition = new Vector3(randomX, 6f, 0f);

        if (Random.value < 0.7f)
        {
            Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
        }
        else
        {
            Instantiate(bombPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
