using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimationController : MonoBehaviour
{

    public InputActionProperty grabAnimation;
    public InputActionProperty shootAnimation;

    public Animator handAnimation;

    // Update is called once per frame
    void Update()
    {
        float grabValue = grabAnimation.action.ReadValue<float>();
        handAnimation.SetFloat("Grab", grabValue);

        float shootValue = shootAnimation.action.ReadValue<float>();
        handAnimation.SetFloat("Shoot", shootValue);
    }
}
