using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour
{
    public GameObject orb1, orb2, orb3;
    public GameObject endingPanel;

    public EnemySpawner enemySpawner;

    public void Update()
    {
        if (orb1.activeSelf == false && orb2.activeSelf == false && orb3.activeSelf == false)
        {
            enemySpawner.sendEnemies = false;
            endingPanel.SetActive(true);
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject enemy in enemies)
                Destroy(enemy);
        }
    }
}
