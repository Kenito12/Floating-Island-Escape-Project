using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineRendererScript : MonoBehaviour
{
    public LineRenderer line;
    public Transform beginningLocation;
    public Transform endLocation;

    // Start is called before the first frame update
    void Start()
    {
        line.SetPosition(0, beginningLocation.position);
        line.SetPosition(1, endLocation.position);
    }
}
