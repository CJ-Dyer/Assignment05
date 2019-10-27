using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSettings : MonoBehaviour
{
    public InputField PlayerField;
    public Text NameText;
    public Dropdown RoundsDropdown;
    public Slider BallSlider;
    public Text BallText;
    public Slider RotatorSlider;
    public Text RotatorText;

    public static string PlayerName = "default";
    public static int PlayerLivesCount = 1;
    public static int PlayerLives = 1;
    public static float BallSpeed = 100.0f;
    public static float RotatorSpeed = 15.0f;

    void Update()
    {
        NameText.text = PlayerField.text;
        PlayerName = PlayerField.text;

        switch(RoundsDropdown.value)
        {
            case 0:
                PlayerLivesCount = 1;
                PlayerLives = PlayerLivesCount;
                break;
            case 1:
                PlayerLivesCount = 2;
                PlayerLives = PlayerLivesCount;
                break;
            case 2:
                PlayerLivesCount = 3;
                PlayerLives = PlayerLivesCount;
                break;
            default:
                PlayerLivesCount = 1;
                PlayerLives = PlayerLivesCount;
                break;
        }

        BallText.text = BallSlider.value.ToString("f2");
        BallSpeed = BallSlider.value;
        RotatorText.text = RotatorSlider.value.ToString("f2");
        RotatorSpeed = RotatorSlider.value;
    }
}
