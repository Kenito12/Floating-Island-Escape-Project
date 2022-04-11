using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class PuzzleManager : MonoBehaviour
{
    //check for puzzle placement 
    public bool puzz1 = false;
    public bool puzz2 = false;
    public bool puzz3 = false;

    //poof VFX
    public VisualEffect poof_Smoke;


    // Update is called once per frame
    void Update()
    {

        if(puzz1 & puzz2 & puzz3)
        {
            Debug.Log("Puzzle has been solved!!!");
        }
        
    }
}
