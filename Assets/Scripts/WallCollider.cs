using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WallCollider : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerSettings.PlayerLives--;

            if (PlayerController.count >= PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", PlayerController.count);
                PlayerPrefs.SetString("HighScorePlayerName", PlayerSettings.PlayerName);
            }

            if (PlayerSettings.PlayerLives != 0)
            {
                PlayerController.count = 0;
                SceneManager.LoadScene("MainScene");
            }
            else
            {
                SceneManager.LoadScene("ExitScene");
            }

        }
    }
}
