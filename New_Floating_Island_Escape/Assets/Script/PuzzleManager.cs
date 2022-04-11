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

    //check puzzle activation
    public bool puzzleIsActive = false;
    
    //number of time that vfx will play
    public int vfxPlayTime = 3;

    //Door obj
    public GameObject door;

    //poof VFX
    public VisualEffect poof_Smoke;



    public void ActivatedPuzzle()
    {

        if (!puzzleIsActive)
        {
            //if puzz1-3 == true play smoke effect and destroy a door obj
            if (puzz1 & puzz2 & puzz3)
            {

                //play poof_smoke vfx for number of time
                for (int i = 0; i < vfxPlayTime; i++)
                {
                    poof_Smoke.Play();
                }

                //destroy a door after second 
                Destroy(door);


                puzzleIsActive = true;
            }
        }

    }
}
