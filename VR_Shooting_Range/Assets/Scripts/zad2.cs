using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;
using UnityEngine.XR.Interaction.Toolkit;

public class zad2 : MonoBehaviour
{
    public ContinuousMoveProviderBase moveProvider;
    public Transform cameraTransform, controllerTransform;
    public InputActionProperty switchLocomotionAction;
    private bool isHeadBased = true;

    void Start()
    {
        moveProvider.forwardSource = cameraTransform;
    }

    void Update()
    {
        if (switchLocomotionAction.action.WasPerformedThisFrame())
        {
            isHeadBased = !isHeadBased;

            if (isHeadBased)
            {
                moveProvider.forwardSource = cameraTransform;
                Debug.Log("Camera");
            }
            else
            {
                moveProvider.forwardSource = controllerTransform;
                Debug.Log("Controller!");
            }
        }
    }
}
