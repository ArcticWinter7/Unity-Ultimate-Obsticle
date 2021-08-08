using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class timer : MonoBehaviour
{
    public Text timerText;
    public GameObject player;
    void FixedUpdate()
    {
        //float _timer = 0;
        //_timer += Time.time;
        //timerText.text = _timer.ToString();

        timerText.text = Time.time.ToString();
    }

}
