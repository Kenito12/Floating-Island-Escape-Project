using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeScript : MonoBehaviour
{
    public LineRenderer line;
    public GameObject beginningLocation;
    public GameObject endLocation;

    // Start is called before the first frame update
    void Start()
    {
        line.SetPosition(0, this.transform.position);
        line.SetPosition(1, endLocation.transform.position);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
