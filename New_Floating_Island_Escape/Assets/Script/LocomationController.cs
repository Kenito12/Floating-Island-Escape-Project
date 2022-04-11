using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LocomationController : MonoBehaviour
{
    public XRController rightTeleportRay;
    public InputHelpers.Button teleportActivationButton;
    public float activationThreshhold = 0.1f;


    // Update is called once per frame
    void Update()
    {
        if (rightTeleportRay)
        {
            FindObjectOfType<SoundManager>().Play("Teleport");
            rightTeleportRay.gameObject.SetActive(CheckIfActivated(rightTeleportRay));
        }
    }

    public bool CheckIfActivated(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, teleportActivationButton, out bool isActivated, activationThreshhold);

        return isActivated;
    }
}
