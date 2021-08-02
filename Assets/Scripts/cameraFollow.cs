using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    //public GameObject cameraHolder;
    public GameObject player;


    void Update()
    {
        gameObject.transform.position = player.gameObject.transform.position;
    }
}
