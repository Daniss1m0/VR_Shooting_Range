using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HideHandsOnGrab : MonoBehaviour
{
    public GameObject leftHand;
    public GameObject rightHand;

    private void OnEnable()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        if (grabInteractable != null)
        {
            grabInteractable.selectEntered.AddListener(OnGrab);
            grabInteractable.selectExited.AddListener(OnRelease);
        }
    }

    private void OnDisable()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        if (grabInteractable != null)
        {
            grabInteractable.selectEntered.RemoveListener(OnGrab);
            grabInteractable.selectExited.RemoveListener(OnRelease);
        }
    }

    private void OnGrab(SelectEnterEventArgs args)
    {
        if (leftHand != null)
        {
            leftHand.SetActive(false);
        }

        if (rightHand != null)
        {
            rightHand.SetActive(false);
        }
    }

    private void OnRelease(SelectExitEventArgs args)
    {
        if (leftHand != null)
        {
            leftHand.SetActive(true);
        }

        if (rightHand != null)
        {
            rightHand.SetActive(true);
        }
    }
}
