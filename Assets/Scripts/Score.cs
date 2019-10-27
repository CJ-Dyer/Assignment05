using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ExitScoreText;
    public Text ExitHighScoreText;

    void Start()
    {
        ExitScoreText.text = "Score: " + PlayerSettings.PlayerName + " - " + PlayerController.count.ToString();
        ExitHighScoreText.text = "High Score: " + PlayerPrefs.GetString("HighScorePlayerName", "default") + " - " + PlayerPrefs.GetInt("HighScore", 0);
    }
}
