using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPuzzle : MonoBehaviour
{

    public PuzzleManager puzzleManager;
    public string correctPuzzle;

    public void OnTriggerEnter(Collider other)
    {

        if(other.name == correctPuzzle)
        {
            switch (other.name)
            {
                case "FirstPuzzle":
                    puzzleManager.puzz1 = true;
                    break;
                case "SecondPuzzle":
                    puzzleManager.puzz2 = true;
                    break;
                case "ThirdPuzzle":
                    puzzleManager.puzz3 = true;
                    break;
                default:
                    Debug.Log("This is not even a puzzle!");
                    break;
            }

            puzzleManager.ActivatedPuzzle();
        }

    }

  
}
