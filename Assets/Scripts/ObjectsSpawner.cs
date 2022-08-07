using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObjectsSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] objectsToSpawn;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float spawnDelay = 1f;

    private void Start()
    {
        StartCoroutine(SpawnDelay());
    }

    private void SpawnObject()
    {
        Instantiate(objectsToSpawn[Random.Range(0, objectsToSpawn.Length)], spawnPoint.position, Quaternion.identity);
    }

    private IEnumerator SpawnDelay()
    {
        SpawnObject();
        yield return new WaitForSeconds(spawnDelay);
        StartCoroutine(SpawnDelay());
    }
}
