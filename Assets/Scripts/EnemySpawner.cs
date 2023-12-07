using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public bool sendEnemies = true;
    private float spawnWait;
    private float spawnWaitLeast = 1;
    private float spawnWaitMost = 3;
    private Vector3 spawnPosition;

    private void Update()
    {
        spawnWait = Random.Range(spawnWaitLeast, spawnWaitMost);
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "EnemyTrigger")
        {
            StartCoroutine(BeginSpawnEnemies());
        }
      
        IEnumerator BeginSpawnEnemies()
        {
            while (sendEnemies == true)
            {
                yield return new WaitForSeconds(spawnWait);

                spawnPosition.y = Random.Range(5f, 10f);
                spawnPosition.z = Random.Range(5f, 25f);
                spawnPosition.x = Random.Range(5f, 10f);

                Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

                yield return new WaitForSeconds(spawnWait);
            }
        }
    }
}