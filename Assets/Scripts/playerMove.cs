using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{


    public Rigidbody player;


    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            player.velocity += new Vector3(-2, 0, 0);
        }
        if (Input.GetKey("s"))
        {
            player.velocity += new Vector3(2, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            player.velocity += new Vector3(0,0,-1);
        }
        if (Input.GetKey("d"))
        {
            player.velocity += new Vector3(0, 0, 1);
        }
    }
}
