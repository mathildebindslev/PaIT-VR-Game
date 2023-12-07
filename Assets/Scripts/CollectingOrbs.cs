using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CollectingOrbs : MonoBehaviour
{
    public GameObject orb;
    public GameObject goodEnvironment;

    public void Collect()
    {
        Debug.Log("Orb1 grabbed");
        goodEnvironment.SetActive(true);
        orb.SetActive(false);
    }
}