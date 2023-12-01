using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit; 

public class Shooting : MonoBehaviour
{
    public InputActionProperty shootAnimation;

    public GameObject shootingObject;
    public Transform spawnPosition;

    public float shootingSpeed = 10f;

   /* void Start()
    {
        XRGrabInteractable shootInteractable = GetComponent<XRGrabInteractable>();
        shootInteractable.activated.AddListener(Shoot);
    } */

    // Update is called once per frame
    void Update()
    {
        float shootValue = shootAnimation.action.ReadValue<float>();

        // Check if the grab animation is playing
        if (shootValue > 0.5f) // Adjust this threshold based on your animation values
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        GameObject newShootingObject = Instantiate(shootingObject);
        newShootingObject.transform.position = spawnPosition.position;
        newShootingObject.GetComponent<Rigidbody>().velocity = spawnPosition.forward * shootingSpeed;
    }

        /* public void Shoot(ActivateEventArgs arg)
        {
            GameObject newShootingObject = Instantiate(shootingObject);
            newShootingObject.transform.position = spawnPosition.position;
            newShootingObject.GetComponent<Rigidbody>().velocity = spawnPosition.forward * shootingSpeed;

            Destroy(newShootingObject, 10f);
        } */
    }
