using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CollectingOrbs : MonoBehaviour
{
    public GameObject orb;

    void Start()
     {
         XRGrabInteractable orb = GetComponent<XRGrabInteractable>();
         orb.activated.AddListener(Collect);
     }

    public void Collect(ActivateEventArgs arg)
    {
        Debug.Log("Orb grabbed");

        // Destroy(gameObject, 10f);
    }
}