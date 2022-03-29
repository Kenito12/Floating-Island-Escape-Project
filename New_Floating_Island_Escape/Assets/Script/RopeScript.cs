using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeScript : MonoBehaviour
{
    public LineRenderer line;
    public GrapplingHook grapplingHookScript;

    // Update is called once per frame
    void Update()
    {
        if (grapplingHookScript.grapple)
        {
            line.SetPosition(0, this.transform.position);
            line.SetPosition(1, grapplingHookScript.hit.point);
        }
        else
        {
            line.SetPosition(0, Vector3.zero);
            line.SetPosition(1, Vector3.zero);
        }
    }
}
