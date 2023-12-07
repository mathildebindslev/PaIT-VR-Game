using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartOver : MonoBehaviour

{

    public GameObject startOverPanel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(StartOverPanel());
        }
    }

    IEnumerator StartOverPanel()
    {
        startOverPanel.SetActive(true);

        yield return new WaitForSeconds(10);

        startOverPanel.SetActive(false);

        SceneManager.LoadScene("GameScene");
    }
}
