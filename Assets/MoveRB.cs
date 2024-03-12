using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody MoveRB;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey("w"))
        {
            MoveRB.AddForce(0, 0, 50);
        }

        if (Input.GetKey("a"))
        {
            MoveRB.AddForce(-50, 0, 0);
        }

        if (Input.GetKey("d"))
        {
            MoveRB.AddForce(50, 0, 0);
        }

        if (Input.GetKey("s"))
        {
            MoveRB.AddForce(0, 0, -50);
        }

    }
}