using System;
using UnityEngine;

public class BalloonSpawner : MonoBehaviour
{
    public GameObject balloonPrefab; // Make sure this is public!

    public float spawnRate = 1f;

    private void Start()
    {
        InvokeRepeating("SpawnBalloon", 0f, spawnRate);
    }

    private void SpawnBalloon()
    {
        float randomX = UnityEngine.Random.Range(-8f, 8f);
        float randomY = UnityEngine.Random.Range(-5f, 5f);
        Vector2 spawnPosition = new Vector2(randomX, randomY);

        Instantiate(balloonPrefab, spawnPosition, Quaternion.identity);
    }
}
