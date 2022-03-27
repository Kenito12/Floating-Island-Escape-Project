using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveZipline : MonoBehaviour
{
    public CharacterController character;
    public GameObject destination;
    public int handCounter = 0;

    private float currentSpeed = 0;
    private float maxSpeed = 10;
    private float acceleration = 0.25f;
    private bool movement = false;

    void Update()
    {
        CalculateAcceleration();
        MovePosition();
    }

    void CalculateAcceleration()
    {
        if (currentSpeed <= maxSpeed)
        {
            currentSpeed += acceleration * Time.deltaTime;
        }
    }

    void MovePosition()
    {
        if (handCounter == 2 || movement == true)
        {
            movement = true;

            if (this.transform.position != destination.transform.position)
            {
                this.transform.position = Vector3.MoveTowards(this.transform.position, destination.transform.position, currentSpeed * Time.deltaTime);
            }
            if (handCounter == 2)
            {
                character.Move((destination.transform.position - this.transform.position).normalized * currentSpeed * Time.deltaTime);

            }
        }
    }
}
