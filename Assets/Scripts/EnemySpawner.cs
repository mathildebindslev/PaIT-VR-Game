using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public bool sendEnemies;
    public float spawnWait;
    public float spawnWaitLeast;
    public float spawnWaitMost;
    public Vector3 spawnPosition;

    private void Start()
    {
        StartCoroutine(BeginSpawnEnemies());
    }

    private void Update()
    {
        spawnWait = Random.Range(spawnWaitLeast, spawnWaitMost);
    }

    public IEnumerator BeginSpawnEnemies()
    {
        while (sendEnemies)
        {
            yield return new WaitForSeconds(spawnWait);

            // spawnPosition.y = Random.Range(-5f, 5f);
            // spawnPosition.z = Random.Range(-5f, 5f);
            // spawnPosition.x = Random.Range(-5f, 5f);
            spawnPosition = transform.localPosition + new Vector3(0,0,0);

            Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

            yield return new WaitForSeconds(spawnWait);
        }
    }
}
