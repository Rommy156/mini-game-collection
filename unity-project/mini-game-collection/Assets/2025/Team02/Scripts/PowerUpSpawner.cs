using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    public GameObject[] powerUpPrefabs;
    public float spawnInterval = 6f;
    public float spawnRangeY = 3.5f;

    void Start()
    {
        InvokeRepeating("SpawnPowerUp", 3f, spawnInterval);
    }

    void SpawnPowerUp()
    {
        int index = Random.Range(0, powerUpPrefabs.Length);

        Vector3 pos = new Vector3(
            0f,
            Random.Range(-spawnRangeY, spawnRangeY),
            0f
        );

        Instantiate(powerUpPrefabs[index], pos, Quaternion.identity);
    }
}
