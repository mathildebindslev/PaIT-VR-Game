using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandController : MonoBehaviour
{

    public InputActionProperty grabAnimation;
    public InputActionProperty shootAnimation;

    public Animator handAnimation;

    public GameObject shootingObject;
    public Transform spawnPosition;

    public float shootingSpeed = 10f;

    public bool isShooting;

    // Update is called once per frame
    void Update()
    {
        float grabValue = grabAnimation.action.ReadValue<float>();
        handAnimation.SetFloat("Grab", grabValue);

        float shootValue = shootAnimation.action.ReadValue<float>();
        handAnimation.SetFloat("Shoot", shootValue);

        // Check if the grab animation is playing
        if (grabValue == 1 && !isShooting) // Adjust this threshold based on your animation values
        {
            StartCoroutine(Shoot());
        }
    }

    IEnumerator Shoot()
    {
        isShooting = true;

        GameObject newShootingObject = Instantiate(shootingObject);
        newShootingObject.transform.position = spawnPosition.position;
        newShootingObject.GetComponent<Rigidbody>().velocity = spawnPosition.forward * shootingSpeed;

        yield return new WaitForSeconds(0.5f);

        isShooting = false;
    }
}
