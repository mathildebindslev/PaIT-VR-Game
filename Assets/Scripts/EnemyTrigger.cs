using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{
    public EnemySpawner enemyCoroutine;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "EnemyTrigger")
        {
            enemyCoroutine.BeginSpawnEnemies();
        }
        else
        {
            Debug.LogWarning("enemyCoroutine reference is not assigned!");
        }

    }
}
