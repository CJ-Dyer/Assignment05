using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameInfo : MonoBehaviour
{
    public Text ScoreText;
    public Text LivesText;
    public Text BallText;
    public Text RotatorText;

    void Update()
    {
        ScoreText.text = "Score: " + PlayerSettings.PlayerName + " - " + PlayerController.count.ToString();
        LivesText.text = "Lives: " + PlayerSettings.PlayerLives.ToString();
        BallText.text = "Ball Speed: " + PlayerSettings.BallSpeed.ToString("f2");
        RotatorText.text = "Rotator Speed: " + PlayerSettings.RotatorSpeed.ToString("f2");
    }
}
