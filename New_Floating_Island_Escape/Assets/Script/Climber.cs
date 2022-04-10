using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Climber : MonoBehaviour
{

    private CharacterController character;
    public  static XRController climbingHand;
    private ContinuousMovement continuousMovement;
    

    // Start is called before the first frame update
    void Start()
    {
        //access both Component at the start
        character = GetComponent<CharacterController>();
        continuousMovement = GetComponent<ContinuousMovement>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //if clibingahdn disable continuousMovement
        if (climbingHand)
        {
            continuousMovement.enabled = false;
            Climb();
        }
        else
        {
            continuousMovement.enabled = true;
        }
    
    }

    //Calculate Climb physic
    void Climb()
    {
        InputDevices.GetDeviceAtXRNode(climbingHand.controllerNode).TryGetFeatureValue(CommonUsages.deviceVelocity, out Vector3 velocity);

        //move player body into the oposite direction
        character.Move( transform.rotation * -velocity * Time.fixedDeltaTime);
    }
}
