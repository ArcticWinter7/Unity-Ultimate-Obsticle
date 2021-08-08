using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class facePlayerAndShoot : MonoBehaviour
{

    public GameObject cannon;
    public GameObject player;
    public int cooldownTimer = 10;
    
    void FixedUpdate()
    {

        cannon.gameObject.transform.LookAt(player.gameObject.transform);

        if (cooldownTimer <= 0)
        {
            Instantiate(cannon, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z) , this.transform.rotation);

            cooldownTimer = 10;
        }
        cooldownTimer--;
        Debug.Log(cooldownTimer);
    }
}
