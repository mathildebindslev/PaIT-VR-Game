using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{
    public float playerHealth;
    public GameObject gameOverPanel;

    public GameObject health5, health4, health3, health2, health1;

    private void Start()
    {
        playerHealth = 5;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy" && playerHealth > 1)
        {
            playerHealth -= 1;
            Destroy(other.gameObject);
        }
        else if (other.tag == "Enemy" && playerHealth <= 1)
        {
            playerHealth = 0;
            StartCoroutine(GameOver());
        }

        switch (playerHealth)
        {
            case 5:
                health5.SetActive(true);
                health4.SetActive(true);
                health3.SetActive(true);
                health2.SetActive(true);
                health1.SetActive(true);
                break;
            case 4:
                health5.SetActive(false);
                health4.SetActive(true);
                health3.SetActive(true);
                health2.SetActive(true);
                health1.SetActive(true);
                break;
            case 3:
                health5.SetActive(false);
                health4.SetActive(false);
                health3.SetActive(true);
                health2.SetActive(true);
                health1.SetActive(true);
                break;
            case 2:
                health5.SetActive(false);
                health4.SetActive(false);
                health3.SetActive(false);
                health2.SetActive(true);
                health1.SetActive(true);
                break;
            case 1:
                health5.SetActive(false);
                health4.SetActive(false);
                health3.SetActive(false);
                health2.SetActive(false);
                health1.SetActive(true);
                break;
            case 0:
                health5.SetActive(false);
                health4.SetActive(false);
                health3.SetActive(false);
                health2.SetActive(false);
                health1.SetActive(false);
                break;
            default:
                print("Incorrect health amount.");
                break;
        }
    }

    IEnumerator GameOver()
    {
        gameOverPanel.SetActive(true);

        yield return new WaitForSeconds(10);

        SceneManager.LoadScene("GameScene");
        gameOverPanel.SetActive(false);
    }
}
