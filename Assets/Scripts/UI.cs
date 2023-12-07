using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject introductionPanel1;
    public GameObject introductionPanel2;

    private void Start()
    {
      StartCoroutine(IntroductionPanel());
    }

    IEnumerator IntroductionPanel()
    {
        introductionPanel1.SetActive(true);
        introductionPanel2.SetActive(false);

        yield return new WaitForSeconds(15f);

        introductionPanel1.SetActive(false);
        introductionPanel2.SetActive(true);

        yield return new WaitForSeconds(10f);
        introductionPanel1.SetActive(false);
        introductionPanel2.SetActive(false);

    }
}