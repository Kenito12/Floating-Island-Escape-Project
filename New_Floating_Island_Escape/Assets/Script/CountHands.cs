using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountHands : MonoBehaviour
{
    public MoveZipline moveZiplineScript;

    public void addCount()
    {
        moveZiplineScript.handCounter++;
    }

    public void subtractCount()
    {
        moveZiplineScript.handCounter--;
    }
}
