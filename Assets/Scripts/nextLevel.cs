using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class nextLevel : MonoBehaviour
{


    public Text maintimer;
    public Text congratsTimer;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            string currentScene = SceneManager.GetActiveScene().name;

            switch (currentScene)
            {
                case "level1":
                    SceneManager.LoadSceneAsync("level2", LoadSceneMode.Single);
                    break;
                case "level2":
                    SceneManager.LoadSceneAsync("level3", LoadSceneMode.Single);
                    break;
                case "level3":
                    SceneManager.LoadSceneAsync("level4", LoadSceneMode.Single);
                    break;
                case "level4":
                    maintimer.enabled = false;
                    congratsTimer.text = "Level complete, your time: " + Time.time.ToString();
                    congratsTimer.enabled = true;
                    break;
            }
        }
    }
}
