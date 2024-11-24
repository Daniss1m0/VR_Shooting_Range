using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class LocomotionChange : MonoBehaviour
{
    public ContinuousMoveProviderBase moveProvider;
    public Transform cameraTransform;
    public Transform controllerTransform; 
    public Button cameraButton; 
    public Button controllerButton; 

    void Start()
    {
        cameraButton.onClick.AddListener(CameraSwitch);
        controllerButton.onClick.AddListener(ControllerSwitch);

        moveProvider.forwardSource = cameraTransform;
    }

    void CameraSwitch()
    {
        moveProvider.forwardSource = cameraTransform;
        Debug.Log("Camera forward source selected.");
    }

    void ControllerSwitch()
    {
        moveProvider.forwardSource = controllerTransform;
        Debug.Log("Controller forward source selected.");
    }
}
