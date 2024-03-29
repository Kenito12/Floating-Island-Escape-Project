using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Audio;

public class GrapplingHook : MonoBehaviour
{

    public CharacterController character;
    public ContinuousMovement continuousMovementScript;
    public LocomationController locomationControllerScript;
    public InputHelpers.Button teleportActivationButton;
    public GameObject previousgun;

    // While shooting
    public float maxDistance = 100.0f;
    public bool grapple;
    public bool grabbed;
    public RaycastHit hit;

    private Vector3 grappleDestination;
    private float currentSpeed = 0.0f;
    private float maxSpeed = 15.0f;
    private float acceleration = 10.0f;

    // After shooting
    private float minSpeed = 0.0f;
    private float deceleration = 12.5f;
    private bool gravity = true;

    // Update is called once per frame
    void Update()
    {
        CheckGravity();
        PlayerToDestination();
    }

    void CheckGravity()
    {
        if (gravity)
        {
            continuousMovementScript.grappling = false;

            if (grabbed)
            {
                character.Move((grappleDestination - this.transform.position).normalized * Mathf.RoundToInt(CalculateDeceleration()) * Time.deltaTime);
            }
        }
        else
        {
            continuousMovementScript.grappling = true;
        }
    }

    void PlayerToDestination()
    {
        if (grapple && character.transform.position != hit.point)
        {
            character.Move((grappleDestination - this.transform.position).normalized * CalculateAcceleration() * Time.deltaTime);
        }
    }

    float CalculateAcceleration()
    {
        if (currentSpeed <= maxSpeed)
        {
            currentSpeed += acceleration * Time.deltaTime;
        }
        return currentSpeed;
    }

    float CalculateDeceleration()
    {
        if (currentSpeed >= minSpeed)
        {
            currentSpeed -= deceleration * Time.deltaTime;
        }
        return currentSpeed;
    }

    public void Shoot()
    {


        if (Physics.Raycast(this.transform.position, this.transform.forward, out hit, maxDistance))
        {

            FindObjectOfType<SoundManager>().Play("Grappling");

            //currentSpeed = 0;
            gravity = false;
            grappleDestination = hit.point;
            grapple = true;
        }
    }

    public void EndShoot()
    {
        gravity = true;
        grapple = false;
        //StartCoroutine(SmoothLerp());
    }

    public void EnableTeleport()
    {
        grabbed = false;
        locomationControllerScript.teleportActivationButton = teleportActivationButton;
    }

    public void DisableTeleport()
    {
        grabbed = true;
        locomationControllerScript.teleportActivationButton = 0;
    }

    public void DestroyPreviousGun()
    {
        Destroy(previousgun);

    }

}


