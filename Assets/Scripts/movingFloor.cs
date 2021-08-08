using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingFloor : MonoBehaviour
{

    public GameObject movingFloorPannel;
    private string floorDirection = "up";
    public float floorMoveSpeed;

    void FixedUpdate()
    {
        float floorElevation = movingFloorPannel.transform.position.y;


        if (floorElevation >= 15)
        {
            floorDirection = "down";
        }else if(floorElevation <= 4)
        {
            floorDirection = "up";
        }

        if(floorDirection == "up")
        {
            floorElevation += floorMoveSpeed;

        }else if(floorDirection == "down") 
        {
            floorElevation -= floorMoveSpeed;
        }

        movingFloorPannel.transform.position = new Vector3(-30.35f, floorElevation, 0.4599071f);

    }
}
